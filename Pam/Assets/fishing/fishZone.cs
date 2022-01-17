using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class fishZone : MonoBehaviour
{
    static public fishZone instanceFZ;

    public GameObject player;
    public Button fishBtn;

    private Player thePlayer;

    private void Awake()
    {
        thePlayer = FindObjectOfType<Player>();
        fishBtn.interactable = false;

        instanceFZ = this;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("player"))
        {
            fishBtn.interactable = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        fishBtn.interactable = false;
    }

}
