using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkSlot : MonoBehaviour
{
    static public checkSlot instanceSlot;

    public Image icon;

    public Text item_text;
    
    private void Awake()
    {
        if (instanceSlot == null)
        {
            DontDestroyOnLoad(this.gameObject);

            instanceSlot = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

    public void Additem(item _item)
    {
        item_text.text = _item.itemName;
        icon.sprite = _item.itemIcon;
        
        RectTransform rect = (RectTransform)icon.transform;

        if (_item.itemID.Equals(20005))
        {
            rect.sizeDelta = new Vector2(40, 80);
        }
        else
        {
            rect.sizeDelta = new Vector2(80, 80);
        }
    }

    //지우는거 필요??
    public void RemoveItem()
    {
        item_text.text = "";
        icon.sprite = null;
    }
}
