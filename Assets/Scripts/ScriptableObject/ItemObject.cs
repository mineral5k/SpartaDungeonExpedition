using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IInteractable
{
    public string GetPrompt();
    public void OnInteract();
}
public class ItemObject : MonoBehaviour,IInteractable
{

    public ItemData data;

    public string GetPrompt()
    {
        string str = $"{data.itemName}\n{data.itemDescription}";
        return str ;

    }

    public void OnInteract()
    {
        throw new System.NotImplementedException();
    }
}
