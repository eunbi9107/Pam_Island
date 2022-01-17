using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyClick : MonoBehaviour
{
    enemyMovement enemyMovement;

    private void Start()
    {
        enemyMovement =FindObjectOfType<enemyMovement>();
    }

    private void OnMouseDown()
    {
        enemyMovement.rabbitClicked();
    }
}
