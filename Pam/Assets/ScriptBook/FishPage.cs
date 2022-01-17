using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishPage : MonoBehaviour
{
    Button button;
    public GameObject FishBook;
    public GameObject CropBook;

    public void onClickButton()
    {
        CropBook.SetActive(true);
        FishBook.SetActive(false);
    }
}
