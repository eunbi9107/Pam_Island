using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class checkFish : MonoBehaviour
{
    static public checkFish instanceCheck;

    public Button exitBtn;

    public GameObject checkFishSet;
    
    private void Awake()
    {
        if (instanceCheck == null)
        {
            DontDestroyOnLoad(this.gameObject);
            checkFishSet.transform.DOScale(Vector3.zero, 0f);
            instanceCheck = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

    public void OpenPanel()
    {
        checkFishSet.transform.DOLocalMove(Vector3.zero, 0);
        checkFishSet.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
    }


    public void ExitBtnClick()
    {
        if (checkFishSet.transform.localScale == Vector3.one)
            checkFishSet.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
    }
}
