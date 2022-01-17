using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[System.Serializable]
public class ShopInfo
{
    public string name;
    public GameObject shopDialog;
}

public class shopManager : MonoBehaviour
{
    static public shopManager instanceShop;

    [SerializeField] ShopInfo[] shopInfo = null;

    void Awake()
    {
        if (instanceShop == null)
        {
            DontDestroyOnLoad(this.gameObject);
            shopInfo[0].shopDialog.transform.DOScale(Vector3.zero, 0f);
            shopInfo[1].shopDialog.transform.DOScale(Vector3.zero, 0f);
            shopInfo[2].shopDialog.transform.DOScale(Vector3.zero, 0f);
            shopInfo[3].shopDialog.transform.DOScale(Vector3.zero, 0f);
            shopInfo[4].shopDialog.transform.DOScale(Vector3.zero, 0f);

            instanceShop = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

    public void shopBtnClick(int num)
    {
        switch (num)
        {
            case 1:
                shopInfo[0].shopDialog.transform.DOLocalMove(Vector3.zero, 0);
                shopInfo[0].shopDialog.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
                break;
            case 2:
                shopInfo[1].shopDialog.transform.DOLocalMove(Vector3.zero, 0);
                shopInfo[1].shopDialog.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
                break;
            case 3:
                shopInfo[2].shopDialog.transform.DOLocalMove(Vector3.zero, 0);
                shopInfo[2].shopDialog.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
                break;
            case 4:
                shopInfo[3].shopDialog.transform.DOLocalMove(Vector3.zero, 0);
                shopInfo[3].shopDialog.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
                break;
            case 5:
                shopInfo[4].shopDialog.transform.DOLocalMove(Vector3.zero, 0);
                shopInfo[4].shopDialog.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
                break;
        }
    }
    public void ExitBtnClick()
    {
        if (shopInfo[0].shopDialog.transform.localScale == Vector3.one)
            shopInfo[0].shopDialog.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
        else if (shopInfo[1].shopDialog.transform.localScale == Vector3.one)
            shopInfo[1].shopDialog.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
        else if (shopInfo[2].shopDialog.transform.localScale == Vector3.one)
            shopInfo[2].shopDialog.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
        else if (shopInfo[3].shopDialog.transform.localScale == Vector3.one)
            shopInfo[3].shopDialog.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
        else if(shopInfo[4].shopDialog.transform.localScale == Vector3.one)
            shopInfo[4].shopDialog.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
    }
}
