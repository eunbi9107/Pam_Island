using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myHome : MonoBehaviour
{
    public GameObject furniture1;
    public GameObject furniture2;
    public GameObject furniture3;
    public GameObject furniture4;
    public GameObject furniture5;
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject buy1;
    public GameObject buy2;
    public GameObject buy3;
    public GameObject buy4;
    public GameObject buy5;
    public GameObject buy6;
    public GameObject buy7;
    GameObject moneyText;
    GameObject director;

    NoticeUI _notice;

    private void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();
    }

    void Start()
    {
        this.director = GameObject.Find("UIManagement");
        this.moneyText = GameObject.Find("money");
    }

    void Update()
    {
        this.moneyText.GetComponent<Text>().text = DataController.Instance.saveData.money.ToString();
        
        if (DataController.Instance.saveData.myFurniture1 == 1)
        {
            furniture1.SetActive(true);
            buy1.SetActive(false);
        }
        if (DataController.Instance.saveData.myFurniture2 == 1)
        {
            furniture2.SetActive(true);
            buy2.SetActive(false);
        }
        if (DataController.Instance.saveData.myFurniture3 == 1)
        {
            furniture3.SetActive(true);
            buy3.SetActive(false);
        }
        if (DataController.Instance.saveData.myFurniture4 == 1)
        {
            furniture4.SetActive(true);
            buy4.SetActive(false);
        }
        if (DataController.Instance.saveData.myFurniture5 == 1)
        {
            furniture5.SetActive(true);
            buy5.SetActive(false);
        }
        if (DataController.Instance.saveData.myLevel == 2)
        {
            level1.SetActive(false);
            level2.SetActive(true);
            buy6.SetActive(false);
            buy7.SetActive(true);
        }
        if (DataController.Instance.saveData.myLevel == 3)
        {
            level1.SetActive(false);
            level3.SetActive(true);
            buy6.SetActive(false);
            buy7.SetActive(false);
        }
    }

    public void buying1()
    {
        if (DataController.Instance.saveData.money >= 1000)
        {
            effectManager.instanceEffect.onClickButtonbuyBtn();
            DataController.Instance.saveData.money -= 1000;
            //UIManagement.myfurniture1 += 1;
            DataController.Instance.saveData.myFurniture1 += 1;
            furniture1.SetActive(true);
            buy1.SetActive(false);
        }

        else if (DataController.Instance.saveData.money < 1000)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("돈이 부족하다냥. 지금은 못 산다냥.");
            _notice.SUB("돈이 부족하다냥. 지금은 못 산다냥.");
        }
    }
    public void buying2()
    {
        if (DataController.Instance.saveData.money >= 1300)
        {
            effectManager.instanceEffect.onClickButtonbuyBtn();
            DataController.Instance.saveData.money -= 1300;
            DataController.Instance.saveData.myFurniture2 += 1;
            furniture2.SetActive(true);
            buy2.SetActive(false);
        }

        else if (DataController.Instance.saveData.money < 1300)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("돈이 부족하다냥. 지금은 못 산다냥.");
            _notice.SUB("돈이 부족하다냥. 지금은 못 산다냥.");
        }
    }
    public void buying3()
    {
        if (DataController.Instance.saveData.money >= 1500)
        {
            effectManager.instanceEffect.onClickButtonbuyBtn();
            DataController.Instance.saveData.money -= 1500;
            DataController.Instance.saveData.myFurniture3 += 1;
            furniture3.SetActive(true);
            buy3.SetActive(false);
        }

        else if (DataController.Instance.saveData.money < 1500)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("돈이 부족하다냥. 지금은 못 산다냥.");
            _notice.SUB("돈이 부족하다냥. 지금은 못 산다냥.");
        }
    }
    public void buying4()
    {
        if (DataController.Instance.saveData.money >= 2000)
        {
            effectManager.instanceEffect.onClickButtonbuyBtn();
            DataController.Instance.saveData.money -= 2000;
            DataController.Instance.saveData.myFurniture4 += 1;
            furniture4.SetActive(true);
            buy4.SetActive(false);
        }

        else if (DataController.Instance.saveData.money < 2000)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("돈이 부족하다냥. 지금은 못 산다냥.");
            _notice.SUB("돈이 부족하다냥. 지금은 못 산다냥.");
        }
    }
    public void buying5()
    {
        if (DataController.Instance.saveData.money >= 2700)
        {
            effectManager.instanceEffect.onClickButtonbuyBtn();
            DataController.Instance.saveData.money -= 2700;
            DataController.Instance.saveData.myFurniture5 += 1;
            furniture5.SetActive(true);
            buy5.SetActive(false);
        }

        else if (DataController.Instance.saveData.money < 2700)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("돈이 부족하다냥. 지금은 못 산다냥.");
            _notice.SUB("돈이 부족하다냥. 지금은 못 산다냥.");
        }
    }

    public void buying6()
    {
        if (DataController.Instance.saveData.money >= 3500)
        {
            effectManager.instanceEffect.onClickButtonbuyBtn();
            DataController.Instance.saveData.money -= 3500;
            DataController.Instance.saveData.myLevel += 1;
            level1.SetActive(false);
            level2.SetActive(true);
            buy6.SetActive(false);
            buy7.SetActive(true);
        }

        else if (DataController.Instance.saveData.money < 3500)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("돈이 부족하다냥. 지금은 못 산다냥.");
            _notice.SUB("돈이 부족하다냥. 지금은 못 산다냥.");
        }

    }
    public void buying7()
    {
        if (DataController.Instance.saveData.money >= 5000)
        {
            effectManager.instanceEffect.onClickButtonbuyBtn();
            DataController.Instance.saveData.money -= 5000;
            DataController.Instance.saveData.myLevel += 1;
            level2.SetActive(false);
            level3.SetActive(true);
            buy7.SetActive(false);
        }

        else if (DataController.Instance.saveData.money < 5000)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("돈이 부족하다냥. 지금은 못 산다냥.");
            _notice.SUB("돈이 부족하다냥. 지금은 못 산다냥.");
        }
    }
}