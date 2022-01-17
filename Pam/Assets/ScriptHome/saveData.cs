using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class SaveData
{
    public int money=300;
    public int myFish1; //갈치
    public int myFish2; //고등어
    public int myFish3; //돌돔
    public int myFish4; //새우
    public int myFish5; //오징어

    public int myCrop1; //당근
    public int myCrop2; //양파
    public int myCrop3; //딸기
    public int myCrop4; //고구마
    public int myCrop5; //토마토

    public int myFurniture1;
    public int myFurniture2;
    public int myFurniture3;
    public int myFurniture4;
    public int myFurniture5;
    public int myLevel=1;

    public float myEnergy=100;
    public float myEnergybar=100;
    
    public int myBuy1; //미끼
    public int myBuy2; //당근 씨앗
    public int myBuy3; //양파 씨앗
    public int myBuy4; //딸기 씨앗
    public int myBuy5; //고구마 씨앗
    public int myBuy6; //토마토 씨앗

    public int fish1deal=0;
    public int fish2deal=0;
    public int fish3deal=0;
    public int fish4deal=0;
    public int fish5deal=0;

    public int crop1deal=0;
    public int crop2deal=0;
    public int crop3deal=0;
    public int crop4deal=0;
    public int crop5deal=0;

    public int crop1State; //당근
    public int crop2State; //양파
    public int crop3State; //딸기
    public int crop4State; //고구마
    public int crop5State; //딸기
}