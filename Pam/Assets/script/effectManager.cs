using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectManager : MonoBehaviour
{
    static public effectManager instanceEffect;

    public GameObject effectOn;
    public GameObject effectOff;
    public AudioClip UIClick;
    public AudioClip book;
    public AudioClip bag;
    public AudioClip fishing;
    public AudioClip fishCatch;
    public AudioClip water;
    public AudioClip harvest;
    public AudioClip buy;
    public AudioClip deal;
    public AudioClip saveLoad;
    public AudioClip rest;
    public AudioClip error; //골드, 미끼, 씨앗 부족 
    AudioSource aud;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();
        instanceEffect = this;
    }

    public void onClickButtonUIBtn()
    {
        this.aud.PlayOneShot(this.UIClick);
    }

    public void onClickButtonbookBtn()
    {
        this.aud.PlayOneShot(this.book);
    }

    public void onClickButtonbagBtn()
    {
        this.aud.PlayOneShot(this.bag);
    }

    public void onClickfishingBtn()
    {
        this.aud.PlayOneShot(this.fishing);
    }

    public void onClickButtoncatchBtn()
    {
        this.aud.PlayOneShot(this.fishCatch);
    }

    public void onClickButtonwaterBtn()
    {
        this.aud.PlayOneShot(this.water);
    }

    public void onClickButtongharvestBtn()
    {
        this.aud.PlayOneShot(this.harvest);
    }

    public void onClickButtonbuyBtn()
    {
        this.aud.PlayOneShot(this.buy);
    }

    public void onClickButtondealBtn()
    {
        this.aud.PlayOneShot(this.deal);
    }

    public void onClickButtonsaveLoadBtn()
    {
        this.aud.PlayOneShot(this.saveLoad);
    }

    public void onClickButtonrestBtn()
    {
        this.aud.PlayOneShot(this.rest);
    }

    public void onClickButtonerrorText()
    {
        this.aud.PlayOneShot(this.error);
    }

    public void onClickeffectOn()
    {
        effectOn.SetActive(true);
        effectOff.SetActive(false);
        aud.volume = 1;
    }

    public void onClickeffectOff()
    {
        effectOn.SetActive(false);
        effectOff.SetActive(true);
        aud.volume = 0;
    }
}