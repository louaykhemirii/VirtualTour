using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.IO;

public class APIhelper : MonoBehaviour
{


    public static character GetCharacter()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://virtuelodc-backend.herokuapp.com/characters/");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<character>(json);

    }
}