using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCondition : MonoBehaviour
{
    public UICondition uiCondition;

    public Condition health { get { return uiCondition.health; } }
    public Condition stamina { get { return uiCondition.stamina; } }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health.Subtract(health.passiveValue * Time.deltaTime);
        stamina.Add(stamina.passiveValue * Time.deltaTime);
        if (stamina.curValue <=0)
        {
            GameManager.Instance.Player.controller.Walk();
        }
    }
}
