using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagement : MonoBehaviour
{
    NoticeUI _notice;

    public GameObject fish1_x; //생선 블라인드
    public GameObject fish2_x;
    public GameObject fish3_x;
    public GameObject fish4_x;
    public GameObject fish5_x;

    public GameObject crop1_x; //작물 블라인드
    public GameObject crop2_x;
    public GameObject crop3_x;
    public GameObject crop4_x;
    public GameObject crop5_x;

    public GameObject fish1intro; //생선 설명출력
    public GameObject fish2intro;
    public GameObject fish3intro;
    public GameObject fish4intro;
    public GameObject fish5intro;

    public GameObject crop1intro; //작물 설명출력
    public GameObject crop2intro;
    public GameObject crop3intro;
    public GameObject crop4intro;
    public GameObject crop5intro;

    public static int myfurniture1 = 0; //가구 개수
    public static int myfurniture2 = 0;
    public static int myfurniture3 = 0;
    public static int myfurniture4 = 0;
    public static int myfurniture5 = 0;

    public static int mylevel = 1;

    public GameObject moneyText;
    public Slider energybar;
    public GameObject energyText;

    public static int money;
    public static float energy;
    static public float barEnergy;

    public static int fish1deal = 0; //생선 판매 개수
    public static int fish2deal = 0;
    public static int fish3deal = 0;
    public static int fish4deal = 0;
    public static int fish5deal = 0;
    public static int crop1deal = 0;
    public static int crop2deal = 0;
    public static int crop3deal = 0;
    public static int crop4deal = 0;
    public static int crop5deal = 0;

    //이건 뭐였을까?
    public static int Buy1 = 0; //현재 미끼 개수
    public static int Buy2 = 0; //현재 당근 씨앗 개수
    public static int Buy3 = 0; //현재 양파 씨앗 개수
    public static int Buy4 = 0; //현재 딸기 씨앗 개수
    public static int Buy5 = 0; //현재 고구마 씨앗 개수
    public static int Buy6 = 0; //현재 토마토 씨앗 개수
    
    public Text fish1;
    public Text fish2;
    public Text fish3;
    public Text fish4;
    public Text fish5;

    public Text crop1;
    public Text crop2;
    public Text crop3;
    public Text crop4;
    public Text crop5;

    public Text bait;
    public Text seed1;
    public Text seed2;
    public Text seed3;
    public Text seed4;
    public Text seed5;

    public void fish1gain()
    {
        if (DataController.Instance.saveData.myFish1 >= 1)
        {
            fish1_x.SetActive(false);
            fish1intro.SetActive(true);
        }
    }
    public void fish2gain()
    {
        if (DataController.Instance.saveData.myFish2 >= 1)
        {
            fish2_x.SetActive(false);
            fish2intro.SetActive(true);
        }
    }
    public void fish3gain()
    {
        if (DataController.Instance.saveData.myFish3 >= 1)
        {
            fish3_x.SetActive(false);
            fish3intro.SetActive(true);
        }
    }

    public void fish4gain()
    {
        if (DataController.Instance.saveData.myFish4 >= 1)
        {
            fish4_x.SetActive(false);
            fish4intro.SetActive(true);
        }
    }

    public void fish5gain()
    {
        if (DataController.Instance.saveData.myFish5 >= 1)
        {
            fish5_x.SetActive(false);
            fish5intro.SetActive(true);
        }
    }

    public void crop1gain()
    {
        if (DataController.Instance.saveData.myCrop1 >= 1)
        {
            crop1_x.SetActive(false);
            crop1intro.SetActive(true);
        }
    }

    public void crop2gain()
    {
        if (DataController.Instance.saveData.myCrop2 >= 1)
        {
            crop2_x.SetActive(false);
            crop2intro.SetActive(true);
        }
    }

    public void crop3gain()
    {
        if (DataController.Instance.saveData.myCrop3 >= 1)
        {
            crop3_x.SetActive(false);
            crop3intro.SetActive(true);
        }
    }

    public void crop4gain()
    {
        if (DataController.Instance.saveData.myCrop4 >= 1)
        {
            crop4_x.SetActive(false);
            crop4intro.SetActive(true);
        }
    }

    public void crop5gain()
    {
        if (DataController.Instance.saveData.myCrop5 >= 1)
        {
            crop5_x.SetActive(false);
            crop5intro.SetActive(true);
        }
    }

    public void SavePlayer()
    {
        //SaveData save = new SaveData();
        //save.money = money;
        //save.myEnergy = energy;
        ////save.myEnergybar = energybar.value;
        //save.myEnergybar=barEnergy;

        //save.myFish1 = miniGame.fishT1;
        //save.myFish2 = miniGame.fishT2;
        //save.myFish3 = miniGame.fishT3;
        //save.myFish4 = miniGame.fishT4;
        //save.myFish5 = miniGame.fishT5;

        //save.myCrop1 = farmWork.cropT1;
        //save.myCrop2 = farmWork.cropT2;
        //save.myCrop3 = farmWork.cropT3;
        //save.myCrop4 = farmWork.cropT4;
        //save.myCrop5 = farmWork.cropT5;

        //save.myBuy1 = miniGame.baitT;
        //save.myBuy2 = farmWork.seedT1;
        //save.myBuy3 = farmWork.seedT2;
        //save.myBuy4 = farmWork.seedT3;
        //save.myBuy5 = farmWork.seedT4;
        //save.myBuy6 = farmWork.seedT5;

        //save.myFurniture1 = myfurniture1;
        //save.myFurniture2 = myfurniture2;
        //save.myFurniture3 = myfurniture3;
        //save.myFurniture4 = myfurniture4;
        //save.myFurniture5 = myfurniture5;
        //save.myLevel = mylevel;

        //SavaManager.Save(save);
        ////DataController.Instance.SaveGameData();

        //Debug.Log("저장");
        //_notice.SUB("저장했다냥");
        //effectManager.instanceEffect.onClickButtonsaveLoadBtn();
    }

    public void LoadPlayer()
    {
        //SaveData save = SavaManager.Load();
        ////SaveData save = DataController.Instance.LoadGameData();
        //money = save.money;
        //energy = save.myEnergy;
        ////energybar.value = save.myEnergybar;
        //barEnergy = save.myEnergybar;

        //miniGame.fishT1 = save.myFish1;
        //miniGame.fishT2 = save.myFish2;
        //miniGame.fishT3 = save.myFish3;
        //miniGame.fishT4 = save.myFish4;
        //miniGame.fishT5 = save.myFish5;

        //farmWork.cropT1 = save.myCrop1;
        //farmWork.cropT2 = save.myCrop2;
        //farmWork.cropT3 = save.myCrop3;
        //farmWork.cropT4 = save.myCrop4;
        //farmWork.cropT5 = save.myCrop5;

        //miniGame.baitT = save.myBuy1;
        //farmWork.seedT1 = save.myBuy2;
        //farmWork.seedT2 = save.myBuy3;
        //farmWork.seedT3 = save.myBuy4;
        //farmWork.seedT4 = save.myBuy5;
        //farmWork.seedT5 = save.myBuy6;

        //myfurniture1 = save.myFurniture1;
        //myfurniture2 = save.myFurniture2;
        //myfurniture3 = save.myFurniture3;
        //myfurniture4 = save.myFurniture4;
        //myfurniture5 = save.myFurniture5;
        //mylevel = save.myLevel;

        //Debug.Log("로드");
        //_notice.SUB("정보를 불러왔다냥");
        //effectManager.instanceEffect.onClickButtonsaveLoadBtn();
    }

    public void QuitGame()
    {
        Debug.Log("quit Game");

        Application.Quit();    
    }

    void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();

        this.moneyText = GameObject.Find("money");
        this.energyText = GameObject.Find("HPText");
    }

    void Update()
    {
        energybar.value = DataController.Instance.saveData.myEnergybar;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DataController.Instance.saveData.money += 100;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            DataController.Instance.saveData.myEnergy -= 5;
            DataController.Instance.saveData.myEnergybar -= 5;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            DataController.Instance.saveData.myEnergy += 5;
            DataController.Instance.saveData.myEnergybar += 5;
        }
        else if (DataController.Instance.saveData.myEnergy <= 0 && DataController.Instance.saveData.myEnergybar <= 0)
        {
            DataController.Instance.saveData.myEnergy = 0;
            DataController.Instance.saveData.myEnergybar = 0;
            _notice.SUB("기운이 하나도 없다냥..");
        }
        else if (DataController.Instance.saveData.myEnergy >= 100 && DataController.Instance.saveData.myEnergybar >= 100)
        {
            DataController.Instance.saveData.myEnergy = 100;
            DataController.Instance.saveData.myEnergybar = 100;
        }
        
        moneyText.GetComponent<Text>().text = DataController.Instance.saveData.money.ToString();
        energyText.GetComponent<Text>().text = Mathf.Round(DataController.Instance.saveData.myEnergy).ToString();

        fish1gain();
        fish2gain();
        fish3gain();
        fish4gain();
        fish5gain();
        crop1gain();
        crop2gain();
        crop3gain();
        crop4gain();
        crop5gain();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();

            Debug.Log("quit Game");
        }
    }

    void LateUpdate()
    {
        fish1.text = string.Format("X{0:n0}", DataController.Instance.saveData.myFish1);
        fish2.text = string.Format("X{0:n0}", DataController.Instance.saveData.myFish2);
        fish3.text = string.Format("X{0:n0}", DataController.Instance.saveData.myFish3);
        fish4.text = string.Format("X{0:n0}", DataController.Instance.saveData.myFish4);
        fish5.text = string.Format("X{0:n0}", DataController.Instance.saveData.myFish5);
        
        crop1.text = string.Format("X{0:n0}", DataController.Instance.saveData.myCrop1);
        crop2.text = string.Format("X{0:n0}", DataController.Instance.saveData.myCrop2);
        crop3.text = string.Format("X{0:n0}", DataController.Instance.saveData.myCrop3);
        crop4.text = string.Format("X{0:n0}", DataController.Instance.saveData.myCrop4);
        crop5.text = string.Format("X{0:n0}", DataController.Instance.saveData.myCrop5);
        
        bait.text = string.Format("X{0:n0}", DataController.Instance.saveData.myBuy1);
        
        seed1.text = string.Format("X{0:n0}", DataController.Instance.saveData.myBuy2);
        seed2.text = string.Format("X{0:n0}", DataController.Instance.saveData.myBuy3);
        seed3.text = string.Format("X{0:n0}", DataController.Instance.saveData.myBuy4);
        seed4.text = string.Format("X{0:n0}", DataController.Instance.saveData.myBuy5);
        seed5.text = string.Format("X{0:n0}", DataController.Instance.saveData.myBuy6);
    }
}