using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MagicianDeal : MonoBehaviour
{
    Button button;
    public GameObject magic;

    private void Awake()
    {
        magic.transform.DOScale(Vector3.zero, 0f);
    }

    public void onClickButton()
    {
        effectManager.instanceEffect.onClickButtonUIBtn();
        magic.SetActive(true);
        magic.transform.DOLocalMove(Vector3.zero, 0);
        magic.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
    }

    public void exitBtnClick()
    {
        effectManager.instanceEffect.onClickButtonUIBtn();
        if (magic.transform.localScale == Vector3.one)
            magic.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
        else
            Application.Quit();
    }
}
