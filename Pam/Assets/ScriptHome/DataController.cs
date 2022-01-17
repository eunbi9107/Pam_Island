using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class DataController : MonoBehaviour
{
    static GameObject _container;
    static GameObject Container
    {
        get
        {
            return _container;
        }
    }

    static DataController _instance;
    public static DataController Instance
    {
        get
        {
            if (!_instance)
            {
                _container = new GameObject();
                _container.name = "DataController";
                _instance = _container.AddComponent(typeof(DataController)) as DataController;
                DontDestroyOnLoad(_container);
            }
            return _instance;
        }
    }

    public string GameDataFileName = ".json";

    public SaveData _saveData;
    public SaveData saveData
    {
        get
        {
            if (_saveData == null)
            {
                LoadGameData();
                SaveGameData();
            }
            return _saveData;
        }
    }

    public void LoadGameData()
    {
        string filePath = Application.persistentDataPath + GameDataFileName;

        if (File.Exists(filePath))
        {
            Debug.Log("불러오기 성공");
            string FromJsonData = File.ReadAllText(filePath);
            _saveData = JsonUtility.FromJson<SaveData>(FromJsonData);
        }
        else
        {
            Debug.Log("새로운 파일 생성");

            _saveData = new SaveData();
        }
    }

    public void SaveGameData()
    {
        string ToJsonData = JsonUtility.ToJson(saveData);
        string filePath = Application.persistentDataPath + GameDataFileName;
        File.WriteAllText(filePath, ToJsonData);
        Debug.Log("저장 완료");
    }

    private void OnApplicationQuit()
    {
        SaveGameData();
    }
}
