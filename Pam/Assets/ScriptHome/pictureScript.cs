using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pictureScript : MonoBehaviour
{
    public GameObject fish1nopage; //그림책 비활성화
    public GameObject fish2nopage;
    public GameObject fish3nopage;
    public GameObject fish4nopage;
    public GameObject fish5nopage;
    public GameObject crop1nopage;
    public GameObject crop2nopage;
    public GameObject crop3nopage;
    public GameObject crop4nopage;
    public GameObject crop5nopage;

    public GameObject fish1story; //그림책 활성화
    public GameObject fish2story;
    public GameObject fish3story;
    public GameObject fish4story;
    public GameObject fish5story;
    public GameObject crop1story;
    public GameObject crop2story;
    public GameObject crop3story;
    public GameObject crop4story;
    public GameObject crop5story;

    GameObject director;

    public Text fish1empty;
    public Text fish2empty;
    public Text fish3empty;
    public Text fish4empty;
    public Text fish5empty;
    public Text crop1empty;
    public Text crop2empty;
    public Text crop3empty;
    public Text crop4empty;
    public Text crop5empty;
    
    void LateUpdate()
    {
        this.fish1empty.GetComponent<Text>().text = "현재 판매 개수: " + DataController.Instance.saveData.fish1deal.ToString();
        this.fish2empty.GetComponent<Text>().text = "현재 판매 개수: " + DataController.Instance.saveData.fish2deal.ToString();
        this.fish3empty.GetComponent<Text>().text = "현재 판매 개수: " + DataController.Instance.saveData.fish3deal.ToString();
        this.fish4empty.GetComponent<Text>().text = "현재 판매 개수: " + DataController.Instance.saveData.fish4deal.ToString();
        this.fish5empty.GetComponent<Text>().text = "현재 판매 개수: " + DataController.Instance.saveData.fish5deal.ToString();
        this.crop1empty.GetComponent<Text>().text = "현재 판매 개수: " + DataController.Instance.saveData.crop1deal.ToString();
        this.crop2empty.GetComponent<Text>().text = "현재 판매 개수: " + DataController.Instance.saveData.crop2deal.ToString();
        this.crop3empty.GetComponent<Text>().text = "현재 판매 개수: " + DataController.Instance.saveData.crop3deal.ToString();
        this.crop4empty.GetComponent<Text>().text = "현재 판매 개수: " + DataController.Instance.saveData.crop4deal.ToString();
        this.crop5empty.GetComponent<Text>().text = "현재 판매 개수: " + DataController.Instance.saveData.crop5deal.ToString();
    }
}