using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class item
{
    public int itemID;
    public string itemName;
    public Sprite itemIcon; 

    public enum ItemType
    {
        fish
    }

    public item(int _itemID, string _itemName)
    {
        itemID = _itemID;
        itemName = _itemName;
        
        itemIcon = Resources.Load("fish/" + itemID.ToString(), typeof(Sprite)) as Sprite;
    }
   
}
