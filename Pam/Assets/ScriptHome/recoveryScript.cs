using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recoveryScript : MonoBehaviour
{
    static public recoveryScript instanceRecovery;

    public GameObject recovery1;
    public GameObject recovery2;
    public GameObject recovery3;
    public GameObject mainPlayer;
    public Text startPauseText;
    public bool recoveryActive = false;

    public Player player;

    private void Awake()
    {
        instanceRecovery = this;
        player= FindObjectOfType<Player>();
    }

    void Update()
    {
        startRecovery();
    }

    void startRecovery()
    {
        if (recoveryActive)
        {
            player.gameObject.SetActive(false);
            if (DataController.Instance.saveData.myLevel == 1)
            {
                recovery1.SetActive(true);
                DataController.Instance.saveData.myEnergybar += Time.deltaTime;
                DataController.Instance.saveData.myEnergy += Time.deltaTime;
            }
            else if (DataController.Instance.saveData.myLevel == 2)
            {
                recovery2.SetActive(true);
                DataController.Instance.saveData.myEnergybar += Time.deltaTime * 1.5f;
                DataController.Instance.saveData.myEnergy += Time.deltaTime * 1.5f;
            }
            else if (DataController.Instance.saveData.myLevel == 3)
            {
                recovery3.SetActive(true);
                DataController.Instance.saveData.myEnergybar += Time.deltaTime * 2;
                DataController.Instance.saveData.myEnergy += Time.deltaTime * 2;
            }
        }
        else if (!recoveryActive)
        {
            player.gameObject.SetActive(true);
            recovery1.SetActive(false);
            recovery2.SetActive(false);
            recovery3.SetActive(false);
        }
    }

    public void StartPauseBtn()
    {
        effectManager.instanceEffect.onClickButtonrestBtn();
        recoveryActive = !recoveryActive;
        startPauseText.text = recoveryActive ? "기상" : "휴식";
    }
}