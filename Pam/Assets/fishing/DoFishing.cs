using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DoFishing : MonoBehaviour
{
    NoticeUI _notice;

    static public DoFishing instanceF;

    public Button fishingBtn;

    public GameObject miniGameSet;

    private Player thePlayer;
    
    private void Awake()
    {
        thePlayer = FindObjectOfType<Player>();
        _notice = FindObjectOfType<NoticeUI>();
        miniGameSet.transform.DOScale(Vector3.zero, 0f);

        instanceF = this;
    }

    public void fishingBtnClick()
    {
        if (fishingBtn.interactable.Equals(true))
        {
            if (DataController.Instance.saveData.myBuy1 >= 1)
            {
                StartCoroutine(miniGamePlay());
            }
            else
            {
                effectManager.instanceEffect.onClickButtonerrorText();
                _notice.SUB("미끼는 상점에서 살 수 있다냥");
            }
        }
    }
    
    IEnumerator miniGamePlay()
    {
        yield return new WaitForSeconds(3.5f);
        miniGameSet.transform.DOLocalMove(Vector3.zero, 0);
        miniGameSet.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);

        yield break;
    }

    public void ExitBtnClick()
    {
        if (miniGameSet.transform.localScale == Vector3.one)
            miniGameSet.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
    }
}
