using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 8.0f;
    private Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    public bool Move(Vector2 targetPos)
    {
        float dis = Vector2.Distance(transform.position, targetPos);

        if (dis >= 0.01f)
        {
            transform.localPosition =
                Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            return true;
        }

        return false;
    }
}
