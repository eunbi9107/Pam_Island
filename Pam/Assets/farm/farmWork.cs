using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.Tilemaps;

 [System.Serializable]
public class farmWorkInfo
{
    public string name;
    public GameObject[] cropPrefab;
    public int count;
    public Transform soilParent;
}

public class farmWork : MonoBehaviour
{
    public static farmWork instanceFarm;

    [SerializeField] farmWorkInfo[] farmWorkinfo = null;

    public Queue<GameObject> carrotQueue = new Queue<GameObject>();
    public Queue<GameObject> onionQueue = new Queue<GameObject>();
    public Queue<GameObject> strawberryQueue = new Queue<GameObject>();
    public Queue<GameObject> sweetpotatoQueue = new Queue<GameObject>();
    public Queue<GameObject> tomatoQueue = new Queue<GameObject>();

    public List<GameObject> childList = new List<GameObject>();

    GameObject child;
    
    public Button waterBtn;
    public Button hoeBtn;
    private bool isWaterClick = false;
    private bool isHoeClick = false;

    public Image cropProgressBarLine;
    public Image cropProgressBar;

    public static bool waterTime = false;
    public static bool harvestTime = false;
    
    Vector2 vector;

    NoticeUI _notice;
    
    public static int cropT1, cropT2, cropT3, cropT4, cropT5 = 0;
    public static int seedT1, seedT2, seedT3, seedT4, seedT5 = 0;

    public static IEnumerator growUpCoroutine;

    private void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();
        
    }

    void Start()
    {
        if (instanceFarm == null)
        {
            DontDestroyOnLoad(this.gameObject);
            instanceFarm = this;
            carrotQueue = InsertQueue(farmWorkinfo[0]);
            onionQueue = InsertQueue(farmWorkinfo[1]);
            strawberryQueue = InsertQueue(farmWorkinfo[2]);
            sweetpotatoQueue = InsertQueue(farmWorkinfo[3]);
            tomatoQueue = InsertQueue(farmWorkinfo[4]);

            waterBtn.interactable = false;
            hoeBtn.interactable = false;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    Queue<GameObject> InsertQueue(farmWorkInfo farmWorkInfo)
    {
        Queue<GameObject> t_queue = new Queue<GameObject>();
        for (int i = 0; i < farmWorkInfo.count; i++)
        {
            for (int j=0;j<farmWorkInfo.count; j++)
            {
                child = Instantiate(farmWorkInfo.cropPrefab[i], transform.position, Quaternion.identity) as GameObject;
                child.SetActive(false);
                child.transform.SetParent(farmWorkInfo.soilParent);
                t_queue.Enqueue(child);
            }
        }
        
        return t_queue;
    }
    
    IEnumerator GrowCoroutine(string crops, farmWorkInfo farmWorkInfo)
    {
        vector =
            new Vector2(farmWorkInfo.soilParent.transform.position.x - 1, farmWorkInfo.soilParent.transform.position.y);
        float progress = 0.0f;
        switch (crops)
        {
            case "carrot":
                if (DataController.Instance.saveData.myBuy2 >= 1)
                {
                    DataController.Instance.saveData.myBuy2 -= 1;
                    effectManager.instanceEffect.onClickButtongharvestBtn();

                    for (int i = 0; i < 4; i++) //4단계
                    {
                        cropProgressBarLine.gameObject.SetActive(true);

                        for (int j = 0; j < 4; j++)
                        {
                            childList.Add(carrotQueue.Dequeue());
                            if(j==0 || j == 1)
                            {
                                if (j == 0)
                                    childList[j].transform.position = new Vector2(vector.x - 2, vector.y + 1);
                                else
                                    childList[j].transform.position = new Vector2(vector.x + 2, vector.y + 1);
                            }
                            else if (j == 2 || j == 3)
                            {
                                if (j == 2)
                                    childList[j].transform.position = new Vector2(vector.x - 2, vector.y - 1.5f);
                                else
                                    childList[j].transform.position = new Vector2(vector.x + 2, vector.y - 1.5f);
                            }
                            childList[j].SetActive(true);
                        }

                        //진행바
                        while (progress <= 1.0f)
                        {
                            cropProgressBar.fillAmount = Mathf.Lerp(0, 1, progress);
                            progress += 0.025f * Time.deltaTime;
                            
                            yield return null;
                        }

                        if (i == 0 || i == 1 || i == 2)
                        {
                            waterTime = true;
                            _notice.SUB("물을 줘야한다냥!");
                            yield return new WaitUntil(() => isWaterClick);
                            yield return new WaitForSecondsRealtime(2f);
                            isWaterClick = !isWaterClick;
                        }
                        if (i == 3)
                        {
                            enemyMovement.instanceEnemy.rabbitSpawn();
                            if (enemyMovement.instanceEnemy.isClick.Equals(false))
                            {
                                harvestTime = true;
                                _notice.SUB("수확 할 시간이다냥!");
                                yield return new WaitUntil(() => isHoeClick);
                                isHoeClick = !isHoeClick;
                                menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;
                                cropProgressBarLine.gameObject.SetActive(false);
                                DataController.Instance.saveData.myCrop1 += 4;
                            }
                            else
                            {
                                yield return new WaitForSecondsRealtime(5f);
                                enemyMovement.instanceEnemy.rabbitList[0].SetActive(false);
                                harvestTime = true;
                                _notice.SUB("수확 할 시간이다냥!");
                                yield return new WaitUntil(() => isHoeClick);
                                isHoeClick = !isHoeClick;
                                menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;
                                cropProgressBarLine.gameObject.SetActive(false);
                                DataController.Instance.saveData.myCrop1 += 2;
                                 _notice.SUB("토끼가 당근을 몇 개 가져갔다냥....");
                            }
                            enemyMovement.instanceEnemy.isClick = false;
                        }
                        for (int j = 0; j < 4; j++)
                        {
                            carrotQueue.Enqueue(childList[j]);
                            childList[j].SetActive(false);
                        }
                        for (int j = 3; j >= 0; j--)
                        {
                            childList.Remove(childList[j]);
                        }
                        progress = 0.0f;
                        
                        DataController.Instance.saveData.myEnergy -= 1;
                        DataController.Instance.saveData.myEnergybar -= 1;
                    }
                }
                else
                {
                    Debug.Log("씨앗은 상점에서 구매할 수 있다냥");
                    _notice.SUB("씨앗은 상점에서 구매할 수 있다냥");
                    menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;
                    effectManager.instanceEffect.onClickButtonerrorText();
                }
                
                break;
            case "onion":
                if (DataController.Instance.saveData.myBuy3 >= 1)
                {
                    DataController.Instance.saveData.myBuy3 -= 1;
                    effectManager.instanceEffect.onClickButtongharvestBtn();
                    for (int i = 0; i < 4; i++)
                    {
                        cropProgressBarLine.gameObject.SetActive(true);
                        for (int j = 0; j < 4; j++) //4개
                        {
                            childList.Add(onionQueue.Dequeue());
                            if (j == 0 || j == 1)
                            {
                                if (j == 0)
                                    childList[j].transform.position = new Vector2(vector.x - 2, vector.y + 1);
                                else
                                    childList[j].transform.position = new Vector2(vector.x + 2, vector.y + 1);
                            }
                            else if (j == 2 || j == 3)
                            {
                                if (j == 2)
                                    childList[j].transform.position = new Vector2(vector.x - 2, vector.y - 1.5f);
                                else
                                    childList[j].transform.position = new Vector2(vector.x + 2, vector.y - 1.5f);
                            }
                            childList[j].SetActive(true);
                        }

                        //진행바
                        while (progress <= 1.0f)
                        {
                            cropProgressBar.fillAmount = Mathf.Lerp(0, 1, progress);
                            progress += 0.025f * Time.deltaTime;

                            yield return null;
                        }

                        if (i == 0 || i == 1 || i == 2)
                        {
                            waterTime = true;
                            _notice.SUB("물을 줘야한다냥!");
                            yield return new WaitUntil(() => isWaterClick);
                            yield return new WaitForSecondsRealtime(1f);
                            isWaterClick = !isWaterClick;
                        }
                        if (i == 3)
                        {
                            enemyMovement.instanceEnemy.rabbitSpawn();
                            if (enemyMovement.instanceEnemy.isClick.Equals(false))
                            {
                                harvestTime = true;
                                _notice.SUB("수확 할 시간이다냥!");
                                yield return new WaitUntil(() => isHoeClick);
                                isHoeClick = !isHoeClick;
                                menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;
                                cropProgressBarLine.gameObject.SetActive(false);
                                DataController.Instance.saveData.myCrop2 += 4;
                            }
                            else
                            {
                                yield return new WaitForSecondsRealtime(5f);
                                enemyMovement.instanceEnemy.rabbitList[0].SetActive(false);
                                harvestTime = true;
                                _notice.SUB("수확 할 시간이다냥!");
                                yield return new WaitUntil(() => isHoeClick);
                                isHoeClick = !isHoeClick;
                                menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;
                                cropProgressBarLine.gameObject.SetActive(false);
                                DataController.Instance.saveData.myCrop2 += 2;
                                _notice.SUB("토끼가 양파를 몇 개 가져갔다냥....");
                            }
                            enemyMovement.instanceEnemy.isClick = false;
                        }
                        for (int j = 0; j < 4; j++)
                        {
                            onionQueue.Enqueue(childList[j]);
                            childList[j].SetActive(false);
                        }
                        for (int j = 3; j >= 0; j--)
                        {
                            childList.Remove(childList[j]);
                        }
                        progress = 0.0f;
                        menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;

                        DataController.Instance.saveData.myEnergy -= 1;
                        DataController.Instance.saveData.myEnergybar -= 1;
                    }
                }
                else {
                    Debug.Log("씨앗은 상점에서 구매할 수 있다냥");
                    _notice.SUB("씨앗은 상점에서 구매할 수 있다냥");
                    menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;
                    effectManager.instanceEffect.onClickButtonerrorText();
                }
                break;
            case "strawberry":
                if (DataController.Instance.saveData.myBuy4 >= 1)
                {
                    DataController.Instance.saveData.myBuy4 -= 1;
                    effectManager.instanceEffect.onClickButtongharvestBtn();
                    for (int i = 0; i < 4; i++)
                    {
                        cropProgressBarLine.gameObject.SetActive(true);
                        for (int j = 0; j < 4; j++) //4개
                        {
                            childList.Add(strawberryQueue.Dequeue());
                            if (j == 0 || j == 1)
                            {
                                if (j == 0)
                                    childList[j].transform.position = new Vector2(vector.x - 2, vector.y + 1);
                                else
                                    childList[j].transform.position = new Vector2(vector.x + 2, vector.y + 1);
                            }
                            else if (j == 2 || j == 3)
                            {
                                if (j == 2)
                                    childList[j].transform.position = new Vector2(vector.x - 2, vector.y - 1.5f);
                                else
                                    childList[j].transform.position = new Vector2(vector.x + 2, vector.y - 1.5f);
                            }
                            childList[j].SetActive(true);
                        }

                        //진행바
                        while (progress <= 1.0f)
                        {
                            cropProgressBar.fillAmount = Mathf.Lerp(0, 1, progress);
                            progress += 0.025f * Time.deltaTime;

                            yield return null;
                        }

                        if (i == 0 || i == 1 || i == 2)
                        {
                            waterTime = true;
                            _notice.SUB("물을 줘야한다냥!");
                            yield return new WaitUntil(() => isWaterClick);
                            yield return new WaitForSecondsRealtime(1f);
                            isWaterClick = !isWaterClick;
                        }
                        if (i == 3)
                        {
                            enemyMovement.instanceEnemy.rabbitSpawn();
                            if (enemyMovement.instanceEnemy.isClick.Equals(false))
                            {
                                harvestTime = true;
                                _notice.SUB("수확 할 시간이다냥!");
                                yield return new WaitUntil(() => isHoeClick);
                                isHoeClick = !isHoeClick;
                                menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;
                                cropProgressBarLine.gameObject.SetActive(false);
                                DataController.Instance.saveData.myCrop3 += 12;
                            }
                            else
                            {
                                yield return new WaitForSecondsRealtime(5f);
                                enemyMovement.instanceEnemy.rabbitList[0].SetActive(false);
                                harvestTime = true;
                                _notice.SUB("수확 할 시간이다냥!");
                                yield return new WaitUntil(() => isHoeClick);
                                isHoeClick = !isHoeClick; 
                                menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;
                                cropProgressBarLine.gameObject.SetActive(false);
                                DataController.Instance.saveData.myCrop3 += 6;
                                _notice.SUB("토끼가 딸기를 몇 개 가져갔다냥....");
                            }

                            enemyMovement.instanceEnemy.isClick = false;
                        }
                        for (int j = 0; j < 4; j++)
                        {
                            strawberryQueue.Enqueue(childList[j]);
                            childList[j].SetActive(false);
                        }
                        for (int j = 3; j >= 0; j--)
                        {
                            childList.Remove(childList[j]);
                        }
                        progress = 0.0f;

                        DataController.Instance.saveData.myEnergy -= 1;
                        DataController.Instance.saveData.myEnergybar -= 1;
                    }
                }
                else {
                    Debug.Log("씨앗은 상점에서 구매할 수 있다냥");
                    _notice.SUB("씨앗은 상점에서 구매할 수 있다냥");
                    menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;
                    effectManager.instanceEffect.onClickButtonerrorText();
                }
                
                break;
            case "sweetPotato":
                if(DataController.Instance.saveData.myBuy5 >= 1)
                {
                    DataController.Instance.saveData.myBuy5 -= 1;
                    effectManager.instanceEffect.onClickButtongharvestBtn();
                    for (int i = 0; i < 4; i++)
                    {
                        cropProgressBarLine.gameObject.SetActive(true);
                        for (int j = 0; j < 4; j++) //4개
                        {
                            childList.Add(sweetpotatoQueue.Dequeue());
                            if (j == 0 || j == 1)
                            {
                                if (j == 0)
                                    childList[j].transform.position = new Vector2(vector.x - 2, vector.y + 1);
                                else
                                    childList[j].transform.position = new Vector2(vector.x + 2, vector.y + 1);
                            }
                            else if (j == 2 || j == 3)
                            {
                                if (j == 2)
                                    childList[j].transform.position = new Vector2(vector.x - 2, vector.y - 1.5f);
                                else
                                    childList[j].transform.position = new Vector2(vector.x + 2, vector.y - 1.5f);
                            }
                            childList[j].SetActive(true);
                        }

                        //진행바
                        while (progress <= 1.0f)
                        {
                            cropProgressBar.fillAmount = Mathf.Lerp(0, 1, progress);
                            progress += 0.025f * Time.deltaTime;

                            yield return null;
                        }

                        if (i == 0 || i == 1 || i == 2)
                        {
                            waterTime = true;
                            _notice.SUB("물을 줘야한다냥!");
                            yield return new WaitUntil(() => isWaterClick);
                            yield return new WaitForSecondsRealtime(1f);
                            isWaterClick = !isWaterClick;
                        }
                        if (i == 3)
                        {
                            enemyMovement.instanceEnemy.rabbitSpawn();
                            if (enemyMovement.instanceEnemy.isClick.Equals(false))
                            {
                                harvestTime = true;
                                _notice.SUB("수확 할 시간이다냥!");
                                yield return new WaitUntil(() => isHoeClick);
                                isHoeClick = !isHoeClick;
                                menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;
                                cropProgressBarLine.gameObject.SetActive(false);
                                DataController.Instance.saveData.myCrop4 += 4;
                            }
                            else
                            {
                                yield return new WaitForSecondsRealtime(5f);
                                enemyMovement.instanceEnemy.rabbitList[0].SetActive(false);
                                harvestTime = true;
                                _notice.SUB("수확 할 시간이다냥!");
                                yield return new WaitUntil(() => isHoeClick);
                                isHoeClick = !isHoeClick;
                                menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;
                                cropProgressBarLine.gameObject.SetActive(false);
                                DataController.Instance.saveData.myCrop4 += 2;
                                _notice.SUB("토끼가 고구마를 몇 개 가져갔다냥....");
                            }

                            enemyMovement.instanceEnemy.isClick = false;
                        }
                        for (int j = 0; j < 4; j++)
                        {
                            sweetpotatoQueue.Enqueue(childList[j]);
                            childList[j].SetActive(false);
                        }
                        for (int j = 3; j >= 0; j--)
                        {
                            childList.Remove(childList[j]);
                        }
                        progress = 0.0f;

                        DataController.Instance.saveData.myEnergy -= 1;
                        DataController.Instance.saveData.myEnergybar -= 1;
                    }
                }
                else {
                    Debug.Log("씨앗은 상점에서 구매할 수 있다냥");
                    _notice.SUB("씨앗은 상점에서 구매할 수 있다냥");
                    menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;
                    effectManager.instanceEffect.onClickButtonerrorText();
                }
                break;
            case "tomato":
                if (DataController.Instance.saveData.myBuy6 >= 1)
                {
                    DataController.Instance.saveData.myBuy6 -= 1;
                    effectManager.instanceEffect.onClickButtongharvestBtn();
                    for (int i = 0; i < 4; i++)
                    {
                        cropProgressBarLine.gameObject.SetActive(true);
                        for (int j = 0; j < 4; j++) //4개
                        {
                            childList.Add(tomatoQueue.Dequeue());
                            if (j == 0 || j == 1)
                            {
                                if (j == 0)
                                    childList[j].transform.position = new Vector2(vector.x - 2, vector.y + 1);
                                else
                                    childList[j].transform.position = new Vector2(vector.x + 2, vector.y + 1);
                            }
                            else if (j == 2 || j == 3)
                            {
                                if (j == 2)
                                    childList[j].transform.position = new Vector2(vector.x - 2, vector.y - 1.5f);
                                else
                                    childList[j].transform.position = new Vector2(vector.x + 2, vector.y - 1.5f);
                            }
                            childList[j].SetActive(true);
                        }

                        //진행바
                        while (progress <= 1.0f)
                        {
                            cropProgressBar.fillAmount = Mathf.Lerp(0, 1, progress);
                            progress += 0.025f * Time.deltaTime;

                            yield return null;
                        }

                        if (i == 0 || i == 1 || i == 2)
                        {
                            waterTime = true;
                            _notice.SUB("물을 줘야한다냥!");
                            yield return new WaitUntil(() => isWaterClick);
                            yield return new WaitForSecondsRealtime(1f);
                            isWaterClick = !isWaterClick;
                        }
                        if (i == 3)
                        {
                            enemyMovement.instanceEnemy.rabbitSpawn();
                            if (enemyMovement.instanceEnemy.isClick.Equals(false))
                            {
                                harvestTime = true;
                                _notice.SUB("수확 할 시간이다냥!");
                                yield return new WaitUntil(() => isHoeClick);
                                isHoeClick = !isHoeClick;
                                menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;
                                cropProgressBarLine.gameObject.SetActive(false);
                                DataController.Instance.saveData.myCrop5 += 8;
                            }
                            else
                            {
                                yield return new WaitForSecondsRealtime(5f);
                                enemyMovement.instanceEnemy.rabbitList[0].SetActive(false);
                                harvestTime = true;
                                _notice.SUB("수확 할 시간이다냥!");
                                yield return new WaitUntil(() => isHoeClick);
                                isHoeClick = !isHoeClick;
                                menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;
                                cropProgressBarLine.gameObject.SetActive(false);
                                DataController.Instance.saveData.myCrop5 += 4;
                                _notice.SUB("토끼가 토마토를 몇 개 먹어버렸냥....");
                            }

                            enemyMovement.instanceEnemy.isClick = false;
                        }
                        for (int j = 0; j < 4; j++)
                        {
                            tomatoQueue.Enqueue(childList[j]);
                            childList[j].SetActive(false);
                        }
                        for (int j = 3; j >= 0; j--)
                        {
                            childList.Remove(childList[j]);
                        }
                        progress = 0.0f;
                        
                        DataController.Instance.saveData.myEnergy -= 1;
                        DataController.Instance.saveData.myEnergybar -= 1;
                    }
                }
                else {
                    Debug.Log("씨앗은 상점에서 구매할 수 있다냥");
                    _notice.SUB("씨앗은 상점에서 구매할 수 있다냥");
                    menuManager.instance.isSeedClick = !menuManager.instance.isSeedClick;
                    effectManager.instanceEffect.onClickButtonerrorText();
                }
                break;
        }
        
        yield return new WaitForSeconds(0.1f);
    }

    private IEnumerator RestartByIEnumerator(string crops, farmWorkInfo farmWorkInfo)
    {
        growUpCoroutine = GrowCoroutine(crops, farmWorkInfo);

        StartCoroutine(growUpCoroutine);

        yield return new WaitForSeconds(3f);
        StopCoroutine(growUpCoroutine);
        Debug.Log("stop Coroutine by IEnumerator");

        yield return new WaitForSeconds(3f);
        StartCoroutine(growUpCoroutine);

        Debug.Log("restart Coroutine by IEnumerator");
    }

    public void Grow(string crops)
    {
        if (crops == "carrot")
        {
            growUpCoroutine = GrowCoroutine(crops, farmWorkinfo[0]);
            StartCoroutine(growUpCoroutine);
        }
        
        else if (crops == "onion")
        {
            growUpCoroutine = GrowCoroutine(crops, farmWorkinfo[1]);
            StartCoroutine(growUpCoroutine);
        }

        else if (crops == "strawberry")
        {
            growUpCoroutine = GrowCoroutine(crops, farmWorkinfo[2]);
            StartCoroutine(growUpCoroutine);
        }

        else if (crops == "sweetPotato")
        {
            growUpCoroutine = GrowCoroutine(crops, farmWorkinfo[3]);
            StartCoroutine(growUpCoroutine);
            //StartCoroutine(GrowCoroutine(crops, farmWorkinfo[3]));
        }

        else if (crops == "tomato")
        {
            growUpCoroutine = GrowCoroutine(crops, farmWorkinfo[4]);
            StartCoroutine(growUpCoroutine);
        }
    }

    public void waterBtnClick() 
    {
        isWaterClick = !isWaterClick;
        waterTime = false;
    }

    public void hoeBtnClick()
    {
        isHoeClick = !isHoeClick;
        harvestTime = false;
    }

    public void waterBtnTrue()
    {
        waterBtn.interactable = true;
    }

    public void hoeBtnTrue()
    {
        hoeBtn.interactable = true;
    }

    public void waterBtnFalse()
    {
        waterBtn.interactable = false;
    }

    public void hoeBtnFalse()
    {
        hoeBtn.interactable = false;
    }
}
