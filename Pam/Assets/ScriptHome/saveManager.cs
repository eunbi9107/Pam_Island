using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SavaManager //건드릴 필요 없음
{
    public static void Save(SaveData data)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Path.Combine(Application.persistentDataPath, "pamIsland.bin");
        FileStream stream = File.Create(path);
        formatter.Serialize(stream, data);
        stream.Close();
    }
    //public static SaveData Load()
    //{
    //    try
    //    {
    //        BinaryFormatter formatter = new BinaryFormatter();
    //        string path = Path.Combine(Application.persistentDataPath, "pamIsland.bin");
    //        FileStream stream = File.OpenRead(path);
    //        SaveData data = (SaveData)formatter.Deserialize(stream);
    //        stream.Close();
    //        return data;
    //    }

    //    catch
    //    {
    //        Debug.Log("저장된 내용이 없다냥!");
    //        return default;
    //    }
    //}
}