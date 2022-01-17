using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[System.Serializable]
public class Book
{
    string name;
    public GameObject[] set;
    public GameObject[] setF;
    public GameObject[] setT;
    public Button[] indexBtn;
}

public class pictureBook : MonoBehaviour
{
    [SerializeField] Book Book = null;

    public Button button;
    public GameObject pictureBookSet;

    GameObject scanObject;
    bool isActive;
    
    void Awake()
    {
        pictureBookSet.transform.DOScale(Vector3.zero, 0f);
    }

    public void pictureBtnActive(GameObject gameObj, bool isAction)
    {
        scanObject = gameObj;
        isActive = isAction;
        
        if (isActive)
        {
            isActive = true;
        }
        else
        {
            isActive = false;
        }
        button.gameObject.SetActive(isActive);
        
    }

    public void onClickButton()
    {
        effectManager.instanceEffect.onClickButtonUIBtn();
        pictureBookSet.SetActive(true);
        pictureBookSet.transform.DOLocalMove(Vector3.zero, 0);
        pictureBookSet.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
    }

    public void onIndexBtnClick(int num)
    {
        effectManager.instanceEffect.onClickButtonbookBtn();
        switch (num)
        {
            case 1:
                for (int i = 0; i < 10; i++)
                {
                    if (i.Equals(0))
                    {
                        if (DataController.Instance.saveData.fish1deal >= 10) //그림 해금
                        {
                            Book.setT[0].SetActive(true);
                            Book.setF[0].SetActive(false);
                        }
                        else if(DataController.Instance.saveData.fish1deal<=9)
                        {
                            Book.setF[0].SetActive(true);
                        }
                        Book.indexBtn[0].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 50);
                    }
                    else
                    {
                        Book.setF[i].SetActive(false);
                        Book.setT[i].SetActive(false);
                        Book.indexBtn[i].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 35);
                    }
                }
                break;
            case 2:
                for(int i = 0; i < 10; i++)
                {
                    if (i.Equals(1))
                    {
                        if (DataController.Instance.saveData.fish2deal >= 10) //그림 해금
                        {
                            Book.setT[1].SetActive(true);
                            Book.setF[1].SetActive(false);
                        }
                        else if (DataController.Instance.saveData.fish2deal <= 9)
                        {
                            Book.setF[1].SetActive(true);
                        }
                        Book.indexBtn[1].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 50);
                    }
                    else
                    {
                        Book.setF[i].SetActive(false);
                        Book.setT[i].SetActive(false);
                        Book.indexBtn[i].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 35);
                    }
                }
                break;
            case 3:
                for (int i = 0; i < 10; i++)
                {
                    if (i.Equals(2))
                    {
                        if (DataController.Instance.saveData.fish3deal >= 10) //그림 해금
                        {
                            Book.setT[2].SetActive(true);
                            Book.setF[2].SetActive(false);
                        }
                        else if (DataController.Instance.saveData.fish3deal <= 9)
                        {
                            Book.setF[2].SetActive(true);
                        }
                        Book.indexBtn[2].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 50);
                    }
                    else
                    {
                        Book.setF[i].SetActive(false);
                        Book.setT[i].SetActive(false);
                        Book.indexBtn[i].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 35);
                    }
                }
                break;
            case 4:
                for (int i = 0; i < 10; i++)
                {
                    if (i.Equals(3))
                    {
                        if (DataController.Instance.saveData.fish4deal >= 10) //그림 해금
                        {
                            Book.setT[3].SetActive(true);
                            Book.setF[3].SetActive(false);
                        }
                        else if (DataController.Instance.saveData.fish4deal <= 9)
                        {
                            Book.setF[3].SetActive(true);
                        }
                        Book.indexBtn[3].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 50);
                    }
                    else
                    {
                        Book.setF[i].SetActive(false);
                        Book.setT[i].SetActive(false);
                        Book.indexBtn[i].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 35);
                    }
                }
                break;
            case 5:
                for (int i = 0; i < 10; i++)
                {
                    if (i.Equals(4))
                    {
                        if (DataController.Instance.saveData.fish5deal >= 10) //그림 해금
                        {
                            Book.setT[4].SetActive(true);
                            Book.setF[4].SetActive(false);
                        }
                        else if (DataController.Instance.saveData.fish5deal <= 9)
                        {
                            Book.setF[4].SetActive(true);
                        }
                        Book.indexBtn[4].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 50);
                    }
                    else
                    {
                        Book.setF[i].SetActive(false);
                        Book.setT[i].SetActive(false);
                        Book.indexBtn[i].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 35);
                    }
                }
                break;
            case 6:
                for (int i = 0; i < 10; i++)
                {
                    if (i.Equals(5))
                    {
                        if (DataController.Instance.saveData.crop1deal >= 10) //그림 해금
                        {
                            Book.setT[5].SetActive(true);
                            Book.setF[5].SetActive(false);
                        }
                        else if (DataController.Instance.saveData.crop1deal <= 9)
                        {
                            Book.setF[5].SetActive(true);
                        }
                        Book.indexBtn[5].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 50);
                    }
                    else
                    {
                        Book.setF[i].SetActive(false);
                        Book.setT[i].SetActive(false);
                        Book.indexBtn[i].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 35);
                    }
                }
                break;
            case 7:
                for (int i = 0; i < 10; i++)
                {
                    if (i.Equals(6))
                    {
                        if (DataController.Instance.saveData.crop2deal >= 10) //그림 해금
                        {
                            Book.setT[6].SetActive(true);
                            Book.setF[6].SetActive(false);
                        }
                        else if (DataController.Instance.saveData.crop2deal <= 9)
                        {
                            Book.setF[6].SetActive(true);
                        }
                        Book.indexBtn[6].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 50);
                    }
                    else
                    {
                        Book.setF[i].SetActive(false);
                        Book.setT[i].SetActive(false);
                        Book.indexBtn[i].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 35);
                    }
                }
                break;
            case 8:
                for (int i = 0; i < 10; i++)
                {
                    if (i.Equals(7))
                    {
                        if (DataController.Instance.saveData.crop3deal >= 10) //그림 해금
                        {
                            Book.setT[7].SetActive(true);
                            Book.setF[7].SetActive(false);
                        }
                        else if (DataController.Instance.saveData.crop3deal <= 9)
                        {
                            Book.setF[7].SetActive(true);
                        }
                        Book.indexBtn[7].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 50);
                    }
                    else
                    {
                        Book.setF[i].SetActive(false);
                        Book.setT[i].SetActive(false);
                        Book.indexBtn[i].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 35);
                    }
                }
                break;
            case 9:
                for (int i = 0; i < 10; i++)
                {
                    if (i.Equals(8))
                    {
                        if (DataController.Instance.saveData.crop4deal >= 10) //그림 해금
                        {
                            Book.setT[8].SetActive(true);
                            Book.setF[8].SetActive(false);
                        }
                        else if (DataController.Instance.saveData.crop4deal <= 9)
                        {
                            Book.setF[8].SetActive(true);
                        }
                        Book.indexBtn[8].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 50);
                    }
                    else
                    {
                        Book.setF[i].SetActive(false);
                        Book.setT[i].SetActive(false);
                        Book.indexBtn[i].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 35);
                    }
                }
                break;
            case 10:
                for (int i = 0; i < 10; i++)
                {
                    if (i.Equals(9))
                    {
                        if (DataController.Instance.saveData.crop5deal >= 10) //그림 해금
                        {
                            Book.setT[9].SetActive(true);
                            Book.setF[9].SetActive(false);
                        }
                        else if (DataController.Instance.saveData.crop5deal <= 9)
                        {
                            Book.setF[9].SetActive(true);
                        }
                        Book.indexBtn[9].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 50);
                    }
                    else
                    {
                        Book.setF[i].SetActive(false);
                        Book.setT[i].SetActive(false);
                        Book.indexBtn[i].GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 35);
                    }
                }
                break;
        }
    }

    public void exitBtnClick()
    {
        effectManager.instanceEffect.onClickButtonUIBtn();
        if (pictureBookSet.transform.localScale == Vector3.one)
            pictureBookSet.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
    }
}
