using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[System.Serializable]
public class enemy
{
    public string name;
    public GameObject rabbitObect;
    public int count;
    public Transform soilParent;
}

public class enemyMovement : MonoBehaviour
{

    public static enemyMovement instanceEnemy;

    [SerializeField] enemy[] enemy = null;

    public List<GameObject> rabbitList = new List<GameObject>();

    GameObject child;

    public bool isClick = false;

    NoticeUI _notice;

    private void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();
    }

    void Start()
    {
        instanceEnemy = this;
        rabbitList = InsertList(enemy[0]);
    }

    List<GameObject> InsertList(enemy enemy)
    {
        List<GameObject> t_list = new List<GameObject>(); //임시 리스트
        for(int i = 0; i < enemy.count; i++)
        {
            GameObject _obj = Instantiate(enemy.rabbitObect,
                new Vector2(enemy.soilParent.position.x, enemy.soilParent.position.y), Quaternion.identity) as GameObject;
            _obj.SetActive(false);
            _obj.transform.SetParent(enemy.soilParent);
            t_list.Add(_obj);
        }
        return t_list;
    }
    
    public void rabbitSpawn()
    {
        int dice = Random.Range(1, 11);

        if(dice.Equals(1) || dice.Equals(2))
        {
            rabbitList[0].SetActive(true);
            _notice.SUB("토끼를 잡아라!!!!");
        }
    }

    public void rabbitClicked()
    {
        isClick = !isClick;
        rabbitList[0].SetActive(false);
    }

}
