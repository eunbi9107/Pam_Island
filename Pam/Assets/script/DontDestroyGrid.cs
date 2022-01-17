using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyGrid : MonoBehaviour
{
    void Awake()
    {
        var obj = FindObjectsOfType<DontDestroyGrid>();

        if (obj.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
