using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.Tilemaps;


public class menuManager : MonoBehaviour
{
    public static menuManager instance; 

    [SerializeField]
    public GameObject UIBagSet;
    public GameObject UIBookSet;
    public GameObject UIAchivementSet;
    public GameObject UISettingSet;
    
    public GameObject cropSet;
    public GameObject fishSet;
    public GameObject kitSet;
    public GameObject kit;
    public Button cropBtn;
    public Button fishBtn;
    public Button kitBtn;
    
    public GameObject carrot;

    public EventSystem eventSystem;

    private farmWork farmWork;
    
    private List<item> getItemList;
    private List<item> bagTapList;

    public RectTransform tf;

    NoticeUI _notice;

    private bool activated;
    private bool tabActivated;

    public bool isSeedClick = false;

    private void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();

        UIBagSet.transform.DOScale(Vector3.zero, 0f);
        UIBookSet.transform.DOScale(Vector3.zero, 0f);
        UIAchivementSet.transform.DOScale(Vector3.zero, 0f);
        UISettingSet.transform.DOScale(Vector3.zero, 0f);
    }

    void Start()
    {
        instance = this;
        farmWork = FindObjectOfType<farmWork>();
        getItemList = new List<item>();
        bagTapList = new List<item>();
    }
    
    public void InitBtnState()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void BagBtnClick()
    {
        UIBagSet.transform.DOLocalMove(Vector3.zero, 0);
        UIBagSet.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
    }

    public void BagTapBtnClick(string tap)
    {
        if (tap == "crop")
        {
            cropSet.SetActive(true);
            fishSet.SetActive(false);
            kitSet.SetActive(false);
            cropBtn.GetComponent<RectTransform>().SetSiblingIndex(5);
            fishBtn.GetComponent<RectTransform>().SetSiblingIndex(1);
            kitBtn.GetComponent<RectTransform>().SetSiblingIndex(0);
            cropBtn.GetComponent<Image>().color = new Color32(218, 198, 133, 255);
            fishBtn.GetComponent<Image>().color = new Color32(102, 79, 10, 137);
            kitBtn.GetComponent<Image>().color = new Color32(102, 79, 10, 137);
            
        }
        else if(tap == "fish")
        {
            cropSet.SetActive(false);
            fishSet.SetActive(true);
            kitSet.SetActive(false);
            cropBtn.GetComponent<RectTransform>().SetSiblingIndex(1);
            fishBtn.GetComponent<RectTransform>().SetSiblingIndex(5);
            kitBtn.GetComponent<RectTransform>().SetSiblingIndex(0);
            cropBtn.GetComponent<Image>().color = new Color32(102, 79, 10, 137);
            fishBtn.GetComponent<Image>().color = new Color32(218, 198, 133, 255);
            kitBtn.GetComponent<Image>().color = new Color32(102, 79, 10, 137);
        }

        else if(tap == "kit")
        {
            cropSet.SetActive(false);
            fishSet.SetActive(false);
            kitSet.SetActive(true);
            cropBtn.GetComponent<RectTransform>().SetSiblingIndex(0);
            fishBtn.GetComponent<RectTransform>().SetSiblingIndex(1);
            kitBtn.GetComponent<RectTransform>().SetSiblingIndex(5);
            cropBtn.GetComponent<Image>().color = new Color32(102, 79, 10, 137);
            fishBtn.GetComponent<Image>().color = new Color32(102, 79, 10, 137);
            kitBtn.GetComponent<Image>().color = new Color32(218, 198, 133, 255);
        }
    }
    
    public void kitBtnClick(string kits)
    {
        if (kits == "carrot")
        {
            UIBagSet.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
            if (isSeedClick)
            {
                _notice.SUB("밭이 작업중이다냥");
            }
            else if (!isSeedClick)
            {
                farmWork.instanceFarm.Grow(kits);
                isSeedClick = !isSeedClick;
            }
        }

        else if (kits == "onion")
        {
            UIBagSet.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
            if (isSeedClick)
            {
                _notice.SUB("밭이 작업중이다냥");
            }
            else if (!isSeedClick)
            {
                farmWork.instanceFarm.Grow(kits);
                isSeedClick = !isSeedClick;
            }
        }
        else if (kits == "strawberry")
        {
            UIBagSet.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
            if (isSeedClick)
            {
                _notice.SUB("밭이 작업중이다냥");
            }
            else if (!isSeedClick)
            {
                farmWork.instanceFarm.Grow(kits);
                isSeedClick = !isSeedClick;
            }
        }
        else if (kits == "sweetPotato")
        {
            UIBagSet.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
            if (isSeedClick)
            {
                _notice.SUB("밭이 작업중이다냥");
            }
            else if (!isSeedClick)
            {
                farmWork.instanceFarm.Grow(kits);
                isSeedClick = !isSeedClick;
            }
        }
        else if (kits == "tomato")
        {
            UIBagSet.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
            if (isSeedClick)
            {
                _notice.SUB("밭이 작업중이다냥");
            }
            else if (!isSeedClick)
            {
                farmWork.instanceFarm.Grow(kits);
                isSeedClick = !isSeedClick;
            }
        }
    }

    public void soilClick()
    {
        if(kit.transform.localScale == Vector3.zero)
        {
            kit.transform.DOMove(Vector3.zero, 0);
            UIBookSet.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
        }
        else
        {
            UIBookSet.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
        }
    }
    
    public void BookBtnClick()
    {
        UIBookSet.transform.DOLocalMove(Vector3.zero, 0);
        UIBookSet.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
    }

    public void AchivementBtnClick()
    {
        UIAchivementSet.transform.DOLocalMove(Vector3.zero, 0);
        UIAchivementSet.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
    }

    public void SettingBtnClick()
    {
        UISettingSet.transform.DOLocalMove(Vector3.zero, 0);
        UISettingSet.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
    }

    public void ExitBtnClick()
    {
        if (UIBagSet.transform.localScale == Vector3.one)
        {
            UIBagSet.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
        }

        else if (UIBookSet.transform.localScale == Vector3.one)
        {
            UIBookSet.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
        }
        else if (UIAchivementSet.transform.localScale == Vector3.one)
        {
            UIAchivementSet.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
        }

        else if (UISettingSet.transform.localScale == Vector3.one)
        {
            UISettingSet.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
        }
    }
}
