using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyNPC : MonoBehaviour
{
    private void Awake()
    {
        var objs = FindObjectsOfType<DontDestroyNPC>();
        if (objs.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
