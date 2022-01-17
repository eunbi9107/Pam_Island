using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[System.Serializable]
public class NpcInfo
{
    public string name;
    public GameObject npcObject;
    public Button npcBtn;
}

public class npcManager : MonoBehaviour
{

    [SerializeField] NpcInfo[] npcInfo = null;
    
    bool isActive;

    private void Awake()
    {
        for (int i = 0; i < 5; i++)
        {
            npcInfo[i].npcBtn.gameObject.SetActive(false);
        }
    }

    public void BtnActive(GameObject gameObj, bool isAction)
    {
        isActive = isAction;
        for (int i = 0; i < 5; i++)
        {
            if (gameObj.name.Equals(npcInfo[i].npcObject.name))
            {
                if (isActive) {
                    isActive = true;
                }
                else {
                    isActive = false;
                }
                npcInfo[i].npcBtn.gameObject.SetActive(isActive);
            }
        }
    }
}
