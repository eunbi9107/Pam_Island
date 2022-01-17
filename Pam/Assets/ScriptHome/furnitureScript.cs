using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class furnitureScript : MonoBehaviour
{
    Button button;
    GameObject moneyText;
    GameObject director;
    public GameObject magic;

    public void onClickbutton1()
    {
        this.director.GetComponent<myHome>().buying1();
        
    }
    public void onClickbutton2()
    {
        this.director.GetComponent<myHome>().buying2();
    }
    public void onClickbutton3()
    {
        this.director.GetComponent<myHome>().buying3();
    }
    public void onClickbutton4()
    {
        this.director.GetComponent<myHome>().buying4();
    }
    public void onClickbutton5()
    {
        this.director.GetComponent<myHome>().buying5();
    }
    public void onClickbutton6()
    {
        this.director.GetComponent<myHome>().buying6();
    }
    public void onClickbutton7()
    {
        this.director.GetComponent<myHome>().buying7();
    }
    public void onClickButtonmagic()
    {
        magic.SetActive(true);
    }

    void Start()
    {
        this.director = GameObject.Find("UIManagement");
        this.moneyText = GameObject.Find("Money");
        this.director = GameObject.Find("myHome");
    }
}