using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CropPage : MonoBehaviour
{
    Button button;
    public GameObject FishBook;
    public GameObject CropBook;

    public void onClickButton()
    {
        CropBook.SetActive(false);
        FishBook.SetActive(true);
    }

}
