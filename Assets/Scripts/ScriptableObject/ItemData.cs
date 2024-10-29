using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Health,
    Stamina,
    Equip
}

[CreateAssetMenu(fileName ="Item",menuName ="NewItem")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public ItemType type;
    public int value;
    
}
