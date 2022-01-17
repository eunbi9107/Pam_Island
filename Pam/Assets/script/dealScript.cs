using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dealScript : MonoBehaviour
{
    NoticeUI _notice;

    private void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();
    }

    public void onClickButtonfishDeal1_1() //갈치 판매
    {
        //miniGame.fishT1>=1
        if (DataController.Instance.saveData.myFish1 >= 1)
        {
            DataController.Instance.saveData.myFish1 -= 1; //현재보유개수
            //UIManagement.money += 250; //현재보유골드
            DataController.Instance.saveData.money += 250;
            DataController.Instance.saveData.fish1deal += 1; //누적판매개수
            
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myFish1 <= 0)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("먕! 갈치가 없는데 어떻게 판다는 거냥!");
            _notice.SUB("먕! 갈치가 없는데 어떻게 판다는 거냥!");
        }
    }
    public void onClickButtonfishDeal1_2()
    {
        if (DataController.Instance.saveData.myFish1 >= 5)
        {
            DataController.Instance.saveData.myFish1 -= 5; //현재보유개수
            DataController.Instance.saveData.money += 1250; //현재보유골드
            DataController.Instance.saveData.fish1deal += 5; //누적판매개수
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myFish1 < 5)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("갈치가 부족하다냥");
            _notice.SUB("갈치가 부족하다냥");
        }
    }
    public void onClickButtonfishDeal2_1() //고등어 판매
    {
        if (DataController.Instance.saveData.myFish2 >= 1)
        {
            DataController.Instance.saveData.myFish2 -= 1; //현재보유개수
            DataController.Instance.saveData.money += 100; //현재보유골드
            DataController.Instance.saveData.fish2deal += 1; //누적판매개수
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myFish2 <= 0)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("먕! 고등어가 없는데 어떻게 판다는 거냥!");
            _notice.SUB("먕! 고등어가 없는데 어떻게 판다는 거냥!");
        }
    }

    public void onClickButtonfishDeal2_2()
    {
        if (DataController.Instance.saveData.myFish2 >= 5)
        {
            DataController.Instance.saveData.myFish2 -= 5; //현재보유개수
            DataController.Instance.saveData.money += 500; //현재보유골드
            DataController.Instance.saveData.fish2deal += 5;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myFish2 < 5)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("고등어가 부족하다냥");
            _notice.SUB("고등어가 부족하다냥");
        }
    }

    public void onClickButtonfishDeal3_1() //돌돔 판매
    {
        if (DataController.Instance.saveData.myFish3 >= 1)
        {
            DataController.Instance.saveData.myFish3 -= 1; //현재보유개수
            DataController.Instance.saveData.money += 300; //현재보유골드
            DataController.Instance.saveData.fish3deal += 1;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myFish3 <= 0)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("먕! 돌돔이 없는데 어떻게 판다는 거냥!");
            _notice.SUB("먕! 돌돔이 없는데 어떻게 판다는 거냥!");
        }
    }

    public void onClickButtonfishDeal3_2()
    {
        if (DataController.Instance.saveData.myFish3 >= 5)
        {
            DataController.Instance.saveData.myFish3 -= 5; //현재보유개수
            DataController.Instance.saveData.money += 1500; //현재보유골드
            DataController.Instance.saveData.fish3deal += 5;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myFish3 < 5)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("돌돔이 부족하다냥");
            _notice.SUB("돌돔이 부족하다냥");
        }
    }

    public void onClickButtonfishDeal4_1() //새우 판매
    {
        if (DataController.Instance.saveData.myFish4 >= 1)
        {
            DataController.Instance.saveData.myFish4 -= 1; //현재보유개수
            DataController.Instance.saveData.money += 200; //현재보유골드
            DataController.Instance.saveData.fish4deal += 1;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myFish4 <= 0)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("먕! 새우가 없는데 어떻게 판다는 거냥!");
            _notice.SUB("먕! 새우가 없는데 어떻게 판다는 거냥!");
        }
    }

    public void onClickButtonfishDeal4_2()
    {
        if (DataController.Instance.saveData.myFish4 >= 5)
        {
            DataController.Instance.saveData.myFish4 -= 5; //현재보유개수
            DataController.Instance.saveData.money += 1000; //현재보유골드
            DataController.Instance.saveData.fish4deal += 5;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myFish4 < 5)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("새우가 부족하다냥");
            _notice.SUB("새우가 부족하다냥");
        }
    }

    public void onClickButtonfishDeal5_1() //오징어 판매
    {
        if (DataController.Instance.saveData.myFish5>= 1)
        {
            DataController.Instance.saveData.myFish5 -= 1; //현재보유개수
            DataController.Instance.saveData.money += 150; //현재보유골드
            DataController.Instance.saveData.fish5deal += 1;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myFish5 <= 0)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("먕! 오징어가 없는데 어떻게 판다는 거냥!");
            _notice.SUB("먕! 오징어가 없는데 어떻게 판다는 거냥!");
        }
    }

    public void onClickButtonfishDeal5_2()
    {
        if (DataController.Instance.saveData.myFish5 >= 5)
        {
            DataController.Instance.saveData.myFish5 -= 5; //현재보유개수
            DataController.Instance.saveData.money += 750; //현재보유골드
            DataController.Instance.saveData.fish5deal += 5;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myFish5 < 5)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("오징어가 부족하다냥");
            _notice.SUB("오징어가 부족하다냥");
        }
    }

    public void onClickButtoncropDeal1_1() //당근 판매
    {
        if (DataController.Instance.saveData.myCrop1 >= 1)
        {
            DataController.Instance.saveData.myCrop1 -= 1; //현재보유개수
            DataController.Instance.saveData.money += 75; //현재보유골드
            DataController.Instance.saveData.crop1deal += 1;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myCrop1 <= 0)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("먕! 당근이 없는데 어떻게 판다는 거냥!");
            _notice.SUB("먕! 당근이 없는데 어떻게 판다는 거냥!");
        }
    }

    public void onClickButtoncropDeal1_2()
    {
        if (DataController.Instance.saveData.myCrop1 >= 5)
        {
            DataController.Instance.saveData.myCrop1 -= 5; //현재보유개수
            DataController.Instance.saveData.money += 375; //현재보유골드
            DataController.Instance.saveData.crop1deal += 5;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myCrop1 < 5)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("당근이 부족하다냥");
            _notice.SUB("당근이 부족하다냥");
        }
    }

    public void onClickButtoncropDeal2_1() //양파 판매
    {
        if (DataController.Instance.saveData.myCrop2 >= 1)
        {
            DataController.Instance.saveData.myCrop2 -= 1; //현재보유개수
            DataController.Instance.saveData.money += 50; //현재보유골드
            DataController.Instance.saveData.crop2deal += 1;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myCrop2 <= 0)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("먕! 양파가 없는데 어떻게 판다는 거냥!");
            _notice.SUB("먕! 양파가 없는데 어떻게 판다는 거냥!");
        }
    }

    public void onClickButtoncropDeal2_2()
    {
        if (DataController.Instance.saveData.myCrop2 >= 5)
        {
            DataController.Instance.saveData.myCrop2 -= 5; //현재보유개수
            DataController.Instance.saveData.money += 250; //현재보유골드
            DataController.Instance.saveData.crop2deal += 5;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myCrop2 < 5)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("양파가 부족하다냥");
            _notice.SUB("양파가 부족하다냥");
        }
    }

    public void onClickButtoncropDeal3_1() //딸기 판매
    {
        if (DataController.Instance.saveData.myCrop3 >= 1)
        {
            DataController.Instance.saveData.myCrop3 -= 1; //현재보유개수
            DataController.Instance.saveData.money += 25; //현재보유골드
            DataController.Instance.saveData.crop3deal += 1;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myCrop3 <= 0)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("먕! 딸기가 없는데 어떻게 판다는 거냥!");
            _notice.SUB("먕! 딸기가 없는데 어떻게 판다는 거냥!");
        }
    }

    public void onClickButtoncropDeal3_2()
    {
        if (DataController.Instance.saveData.myCrop3 >= 5)
        {
            DataController.Instance.saveData.myCrop3 -= 5; //현재보유개수
            DataController.Instance.saveData.money += 125; //현재보유골드
            DataController.Instance.saveData.crop3deal += 5;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myCrop3 < 5)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("딸기가 부족하다냥");
            _notice.SUB("딸기가 부족하다냥");
        }
    }

    public void onClickButtoncropDeal4_1() //고구마 판매
    {
        if (DataController.Instance.saveData.myCrop4 >= 1)
        {
            DataController.Instance.saveData.myCrop4 -= 1; //현재보유개수
            DataController.Instance.saveData.money += 75; //현재보유골드
            DataController.Instance.saveData.crop4deal += 1;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myCrop4 <= 0)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("먕! 고구마가 없는데 어떻게 판다는 거냥!");
            _notice.SUB("먕! 고구마가 없는데 어떻게 판다는 거냥!");
        }
    }

    public void onClickButtoncropDeal4_2()
    {
        if (DataController.Instance.saveData.myCrop4 >= 5)
        {
            DataController.Instance.saveData.myCrop4 -= 5; //현재보유개수
            DataController.Instance.saveData.money += 375; //현재보유골드
            DataController.Instance.saveData.crop4deal += 5;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myCrop4 < 5)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("고구마가 부족하다냥");
            _notice.SUB("고구마가 부족하다냥");
        }
    }

    public void onClickButtoncropDeal5_1() //토마토 판매
    {
        if (DataController.Instance.saveData.myCrop5 >= 1)
        {
            DataController.Instance.saveData.myCrop5 -= 1; //현재보유개수
            DataController.Instance.saveData.money += 50; //현재보유골드
            DataController.Instance.saveData.crop5deal += 1;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myCrop5 <= 0)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("먕! 토마토가 없는데 어떻게 판다는 거냥!");
            _notice.SUB("먕! 토마토가 없는데 어떻게 판다는 거냥!");
        }
    }

    public void onClickButtoncropDeal5_2()
    {
        if (DataController.Instance.saveData.myCrop5 >= 5)
        {
            DataController.Instance.saveData.myCrop5 -= 5; //현재보유개수
            DataController.Instance.saveData.money += 250; //현재보유골드
            DataController.Instance.saveData.crop5deal += 5;
            effectManager.instanceEffect.onClickButtondealBtn();
        }
        else if (DataController.Instance.saveData.myCrop5 < 5)
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("토마토가 부족하다냥");
            _notice.SUB("토마토가 부족하다냥");
        }
    }

    public void onClickButtonBuy1_1() //지렁이 구매
    {
        if(DataController.Instance.saveData.money >= 50)
        {
            DataController.Instance.saveData.money -= 50;
            DataController.Instance.saveData.myBuy1 += 1;
            effectManager.instanceEffect.onClickButtonbuyBtn();
        }
        else
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("골드가 부족하다냥");
            _notice.SUB("골드가 부족하다냥");
        }
    }

    public void onClickButtonBuy1_2() //지렁이 구매
    {
        if (DataController.Instance.saveData.money >= 250)
        {
            DataController.Instance.saveData.money -= 250;
            //miniGame.baitT += 5;
            DataController.Instance.saveData.myBuy1 += 5;
            effectManager.instanceEffect.onClickButtonbuyBtn();
        }
        else
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("골드가 부족하다냥");
            _notice.SUB("골드가 부족하다냥");
        }
    }

    public void onClickButtonBuy2_1() //당근 씨앗 구매
    {
        if (DataController.Instance.saveData.money >= 200)
        {
            DataController.Instance.saveData.money -= 200;
            DataController.Instance.saveData.myBuy2 += 1;
            effectManager.instanceEffect.onClickButtonbuyBtn();
        }
        else
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("골드가 부족하다냥");
            _notice.SUB("골드가 부족하다냥");
        }
       
    }

    public void onClickButtonBuy2_2()
    {
        if (DataController.Instance.saveData.money >= 1000)
        {
            DataController.Instance.saveData.money -= 1000;
            DataController.Instance.saveData.myBuy2 += 5;
            effectManager.instanceEffect.onClickButtonbuyBtn();
        }
        else
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("골드가 부족하다냥");
            _notice.SUB("골드가 부족하다냥");
        }
    }

    public void onClickButtonBuy3_1() //양파 씨앗 구매
    {
        if (DataController.Instance.saveData.money >= 100)
        {
            DataController.Instance.saveData.money -= 100;
            DataController.Instance.saveData.myBuy3 += 1;
            effectManager.instanceEffect.onClickButtonbuyBtn();
        }
        else
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("골드가 부족하다냥");
            _notice.SUB("골드가 부족하다냥");
        }
    }

    public void onClickButtonBuy3_2()
    {
        if(DataController.Instance.saveData.money >= 500)
        {
            DataController.Instance.saveData.money -= 500;
            DataController.Instance.saveData.myBuy3 += 5;
            effectManager.instanceEffect.onClickButtonbuyBtn();
        }
        else
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("골드가 부족하다냥");
            _notice.SUB("골드가 부족하다냥");
        }
    }

    public void onClickButtonBuy4_1() //딸기 씨앗 구매
    {
        if(DataController.Instance.saveData.money >= 200)
        {
            DataController.Instance.saveData.money -= 200;
            DataController.Instance.saveData.myBuy4 += 1;
            effectManager.instanceEffect.onClickButtonbuyBtn();
        }
        else
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("골드가 부족하다냥");
            _notice.SUB("골드가 부족하다냥");
        }
    }

    public void onClickButtonBuy4_2()
    {
        if (DataController.Instance.saveData.money >= 1000)
        {
            DataController.Instance.saveData.money -= 1000;
            DataController.Instance.saveData.myBuy4 += 5;
            effectManager.instanceEffect.onClickButtonbuyBtn();
        }
        else
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("골드가 부족하다냥");
            _notice.SUB("골드가 부족하다냥");
        }
    }

    public void onClickButtonBuy5_1() //고구마 씨앗 구매
    {
        if (DataController.Instance.saveData.money >= 200)
        {
            DataController.Instance.saveData.money -= 200;
            DataController.Instance.saveData.myBuy5 += 1;
            effectManager.instanceEffect.onClickButtonbuyBtn();
        }
        else
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("골드가 부족하다냥");
            _notice.SUB("골드가 부족하다냥");
        }
    }

    public void onClickButtonBuy5_2()
    {
        if (DataController.Instance.saveData.money >= 1000)
        {
            DataController.Instance.saveData.money -= 1000;
            DataController.Instance.saveData.myBuy5 += 5;
            effectManager.instanceEffect.onClickButtonbuyBtn();
        }
        else
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("골드가 부족하다냥");
            _notice.SUB("골드가 부족하다냥");
        }
    }

    public void onClickButtonBuy6_1() //토마토 씨앗 구매
    {
        if (DataController.Instance.saveData.money >= 300)
        {
            DataController.Instance.saveData.money -= 300;
            DataController.Instance.saveData.myBuy6 += 1;
            effectManager.instanceEffect.onClickButtonbuyBtn();
        }
        else
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("골드가 부족하다냥");
            _notice.SUB("골드가 부족하다냥");
        }
    }

    public void onClickButtonBuy6_2()
    {
        if (DataController.Instance.saveData.money >= 1500)
        {
            DataController.Instance.saveData.money -= 1500;
            DataController.Instance.saveData.myBuy6 += 5;
            effectManager.instanceEffect.onClickButtonbuyBtn();
        }
        else
        {
            effectManager.instanceEffect.onClickButtonerrorText();
            Debug.Log("골드가 부족하다냥");
            _notice.SUB("골드가 부족하다냥");
        }
    }
}