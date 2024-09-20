using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintJSON : MonoBehaviour
{
    public TextAsset json;
    void Start()
    {
        Debug.Log(JSONReader.GetJSON(json).str1);   
    }
}
public static class JSONReader {
    public static JSONExample GetJSON(TextAsset json) {
        JSONExample example = JsonUtility.FromJson<JSONExample>(json.text);
        return example;
    }
}
[System.Serializable]
public class JSONExample {
    public int num1;
    public string str1;
    public bool bool1;
}
