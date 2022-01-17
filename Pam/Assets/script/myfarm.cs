using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myfarm : MonoBehaviour
{
    GameObject director;

    void Start()
    {
        this.director = GameObject.Find("farmWork");    
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "cat" && farmWork.waterTime == true)
        {
            this.director.GetComponent<farmWork>().waterBtnTrue();
        }

        else if (other.gameObject.tag == "cat" && farmWork.harvestTime == true)
        {
            this.director.GetComponent<farmWork>().hoeBtnTrue();
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "cat")
        {
            this.director.GetComponent<farmWork>().waterBtnFalse();
            this.director.GetComponent<farmWork>().hoeBtnFalse();
        }
    }
}
