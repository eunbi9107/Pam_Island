using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour
{
    static public Player instance;

    public static float moveSpeed=8f;
    private Vector3 vector;
    private Vector2 dir;
    bool isPointerOverGame;

    public string currentMapName;

    Touch touch;
    Vector3 touchPos, moveDir;
    float previousTouch, currentTouch;

    Vector3 dirVec;
    GameObject scanObject;

    public static GameObject player;

    Rigidbody2D rigid;

    private BoxCollider2D boxCollider;
    public LayerMask layerMask;

    public Animator animator;

    public Button fishBtn;
    public Button hoeBtn;
    public Button waterBtn;

    public bool isClick = false;
    private bool isActive;

    NoticeUI _notice;
    public npcManager npcManager;
    public pictureBook pictureBook;
    public recoveryScript recoveryScript;

    void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject); 
            boxCollider = GetComponent<BoxCollider2D>();
            animator = GetComponent<Animator>();
            rigid = GetComponent<Rigidbody2D>();
            _notice = FindObjectOfType<NoticeUI>();
            moveSpeed = 8f;

            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isPointerOverGame = EventSystem.current.IsPointerOverGameObject();

            vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        dir = vector - transform.position;

         if (isPointerOverGame.Equals(false) && !IsPointerOverUIObject(Input.mousePosition))
        {
            shopManager.instanceShop.ExitBtnClick();
            
            animator.SetFloat("DirX", dir.x);
            animator.SetFloat("DirY", dir.y);
            
            if(DataController.Instance.saveData.myBuy1 >= 1)
            {
                if (isClick)
                {
                    moveSpeed = 0f;
                }
                else
                {
                    if (DataController.Instance.saveData.myEnergy <= 20)
                    {
                        moveSpeed = 2.5f;
                    }
                    else if (DataController.Instance.saveData.myEnergy > 20 && DataController.Instance.saveData.myEnergy <= 60)
                    {
                        moveSpeed = 5f;
                    }
                    else
                    {
                        moveSpeed = 8f;
                    }
                }
            }
            else
            {
                if (DataController.Instance.saveData.myEnergy <= 20)
                {
                    moveSpeed = 2.5f;
                }
                else if (DataController.Instance.saveData.myEnergy > 20 && DataController.Instance.saveData.myEnergy <= 60)
                {
                    moveSpeed = 5f;
                }
                else
                {
                    moveSpeed = 8f;
                }
            }
            
            RaycastHit2D hit;

            Vector2 start = transform.position; 
            Vector2 end = start + new Vector2(dir.x, dir.y);

            boxCollider.enabled = false;
            hit = Physics2D.Linecast(start, end, layerMask);
            boxCollider.enabled = true;

            if (dir != Vector2.zero)
            {
                animator.SetBool("Walking", true);
                if (hit.transform != null)
                {
                    animator.SetBool("Walking", false);
                }
            }
            else
            {
                animator.SetBool("Walking", false);
            }
            
            if (dir.y > 0f)
            { 
                dirVec = Vector3.up;
            }

            transform.position = Vector2.MoveTowards(transform.position, vector, Time.deltaTime * moveSpeed);
            
            RaycastHit2D rayHit = Physics2D.Raycast(rigid.position + new Vector2(0, 1), dirVec, 1f, LayerMask.GetMask("npcObject"));

            if (rayHit.collider != null)
            {
                scanObject = rayHit.collider.gameObject;
            }
            else
            {
                scanObject = null;
            }
        }
    }
    
    public bool IsPointerOverUIObject(Vector2 touchPos)
    {
        PointerEventData eventDataCurrentPosition
            = new PointerEventData(EventSystem.current);

        eventDataCurrentPosition.position = touchPos;

        List<RaycastResult> results = new List<RaycastResult>();

        EventSystem.current
            .RaycastAll(eventDataCurrentPosition, results);

        return results.Count > 0;
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("npc") && scanObject != null)
        {
            npcManager.BtnActive(scanObject, true);
            animator.SetBool("Walking", false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (scanObject != null) {
            npcManager.BtnActive(scanObject, false);
        }
    }
    
    public void changeFishing()
    {
        if (!isClick)
        {
            if (DataController.Instance.saveData.myBuy1 >= 1)
            {
                animator.SetBool("Fishing", true);
                effectManager.instanceEffect.onClickfishingBtn();
            }
        }
        isClick = !isClick;
        Debug.Log("isClick: " + isClick);
    }

    public void recoveryBtn()
    {
        if (recoveryScript.recoveryActive == true)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }
    }
}
