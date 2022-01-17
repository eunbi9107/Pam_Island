using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveToHome : MonoBehaviour
{
    public string transferMapName; //이동할 맵 이름(집 맵 이름)
    public string transferMapHome; //집에서 메인으로 (메인 맵 이름)
    public Transform target;
    
    public Button fishingBtn;
    public Button hoeBtn;
    public Button waterBtn;

    private Player thePlayer;
    private MainCamera theCemera;
    
    private void Start()
    {
        thePlayer = FindObjectOfType<Player>();
        theCemera = FindObjectOfType<MainCamera>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("homePotal"))
        {
            thePlayer.currentMapName = transferMapName;
            LoadingSceneManager.LoadScene(transferMapName);

            fishingBtn.gameObject.SetActive(false);
            hoeBtn.gameObject.SetActive(false);
            waterBtn.gameObject.SetActive(false);
            theCemera.gameObject.SetActive(false);
        }

        else if (collision.gameObject.CompareTag("PamPotal"))
        {
            thePlayer.currentMapName = transferMapHome;
            LoadingSceneManager.LoadScene(transferMapHome);

            fishingBtn.gameObject.SetActive(true);
            hoeBtn.gameObject.SetActive(true);
            waterBtn.gameObject.SetActive(true);
            theCemera.gameObject.SetActive(true);
        }
    }
}
