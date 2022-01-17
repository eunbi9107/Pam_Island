using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmManager : MonoBehaviour
{
    public AudioClip myMainBGM;
    public GameObject bgmOn;
    public GameObject bgmOff;
    AudioSource mainAud;

    void Start()
    {
        this.mainAud = GetComponent<AudioSource>();
        mainAud.loop = true;
        mainAud.clip = myMainBGM;
        mainAud.Play();
    }
    public void onClickButtonsoundStart() //클릭 시 재생
    {
        bgmOn.SetActive(true);
        bgmOff.SetActive(false);
        mainAud.mute = false;
    }

    public void onClickButtonsoundStop() //클릭 시 중지
    {
        bgmOn.SetActive(false);
        bgmOff.SetActive(true);
        mainAud.mute = true;
    }
}
