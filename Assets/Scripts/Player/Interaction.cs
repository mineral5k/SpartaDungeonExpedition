using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public float checkRate = 0.05f;
    private float lastCheckTime;
    public float maxCheckDistance;
    public LayerMask layerMask;

    public GameObject curInteractGameObject;
    public IInteractable curInteractable;

    public TextMeshProUGUI prompt;
    private Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, maxCheckDistance,layerMask))
        {
            if(hit.collider.gameObject != curInteractGameObject)
            {
                curInteractGameObject = hit.collider.gameObject;
                curInteractable = hit.collider.gameObject.GetComponent<IInteractable>();
                SetPromptText();
            }
        }
        else
        {
            curInteractGameObject = null;
            curInteractable = null;
            prompt.gameObject.SetActive(false);
        }
    }

    void SetPromptText()
    {
        prompt.text = curInteractable.GetPrompt();
        prompt.gameObject.SetActive(true);
    }

    public void OnInteract()
    {
        ItemData itemdata = curInteractGameObject.GetComponent<ItemObject>().data;
        switch (itemdata.type)
        {
            case ItemType.Health:
                GameManager.Instance.Player.condition.health.Add(itemdata.value);
                break;
            case ItemType.Stamina:
                GameManager.Instance.Player.condition.stamina.Add(itemdata.value);
                break;
        }
    }

}
