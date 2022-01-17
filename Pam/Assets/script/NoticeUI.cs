using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoticeUI : MonoBehaviour
{
    [Header("SubNotice")]
    public GameObject noticeBox;
    public Text boxText;
    public Animator noticeAni;

    private WaitForSeconds _UIDelay1 = new WaitForSeconds(2.0f);
    private WaitForSeconds _UIDelay2 = new WaitForSeconds(0.3f);

    void Start()
    {
        noticeBox.SetActive(false);
    }

    public void SUB(string message)
    {
        boxText.text = message;
        noticeBox.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(TextDelay());
    }

    IEnumerator TextDelay()
    {
        noticeBox.SetActive(true);
        noticeAni.SetBool("isOn", true);
        yield return _UIDelay1;
        noticeAni.SetBool("isOn", false);
        yield return _UIDelay2;
        noticeBox.SetActive(false);
    }
}