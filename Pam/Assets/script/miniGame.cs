using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class miniGame : MonoBehaviour
{
    public static miniGame instanceMini;

    Vector3 pos;
    float delta = 250.0f;
    float speed = 3.0f;
    float nowFish;
    public int random;

    public static int fishT1, fishT2, fishT3, fishT4, fishT5 = 0;
    public static int baitT = 0;

    public GameObject fishingCat;

    private List<item> checkFishList;

    NoticeUI _notice;

    private void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();
        instanceMini = this;
    }

    void Start()
    {
        pos = new Vector3(600, 275, 0);

        checkFishList = new List<item>();
        checkFishList.Add(new item(20001, "갈치"));
        checkFishList.Add(new item(20002, "고등어"));
        checkFishList.Add(new item(20003, "돌돔"));
        checkFishList.Add(new item(20004, "새우"));
        checkFishList.Add(new item(20005, "오징어"));
    }

    void Update()
    {
        random = Random.Range(1, 11);

        Vector3 v = pos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
        nowFish = v.x;
        if (v.x <= 380)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (v.x >= 835)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void onClickfishingGame()
    {
        if (random == 1 && 550 <= nowFish && nowFish <= 630)
        {
            _notice.SUB("돌돔을 낚았다냥!");
            checkSlot.instanceSlot.Additem(checkFishList[2]);
            DataController.Instance.saveData.myFish3 += 1;

            StartCoroutine(Open());
        }
        else if (1 < random && random < 4 && 550 <= nowFish && nowFish <= 630)
        {
            _notice.SUB("오징어를 낚았다냥!");
            checkSlot.instanceSlot.Additem(checkFishList[4]);
            DataController.Instance.saveData.myFish5 += 1;

            StartCoroutine(Open());
        }
        else if (3 < random && random < 6 && 550 <= nowFish && nowFish <= 630)
        {
            _notice.SUB("새우를 낚았다냥!");
            checkSlot.instanceSlot.Additem(checkFishList[3]);
            DataController.Instance.saveData.myFish4 += 1;

            StartCoroutine(Open());
        }
        else if (5 < random && random < 8 && 550 <= nowFish && nowFish <= 630)
        {
            _notice.SUB("갈치를 낚았다냥!");
            checkSlot.instanceSlot.Additem(checkFishList[0]);
            DataController.Instance.saveData.myFish1 += 1;

            StartCoroutine(Open());
        }
        else if (8 <= random && random <= 10 && 550 <= nowFish && nowFish <= 630)
        {
            _notice.SUB("고등어를 낚았다냥!");
            checkSlot.instanceSlot.Additem(checkFishList[1]);
            DataController.Instance.saveData.myFish2 += 1;

            StartCoroutine(Open());
        }
        else
        {
            _notice.SUB("물고기를 놓쳤다냥..");
        }
        Player.instance.animator.SetBool("Fishing", false);
        Player.instance.isClick = !Player.instance.isClick;
        
        DataController.Instance.saveData.myBuy1 -= 1;
        DataController.Instance.saveData.myEnergy -= 1;
        DataController.Instance.saveData.myEnergybar -= 1;
    }

    IEnumerator Open()
    {
        yield return new WaitForSeconds(0.3f);
        checkFish.instanceCheck.OpenPanel();

        yield break;
    }
}