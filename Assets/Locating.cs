using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class Locating : MonoBehaviour
{
    string country;
    // Start is called before the first frame update
    void Start()
    {
        //country = "";
        //StartCoroutine(GetCountry());
       
    }

    // Update is called once per frame
    IEnumerator GetCountry(){
        UnityWebRequest request = UnityWebRequest.Get("https://extreme-ip-lookup.com/json");
        yield return request.Send();
        country = "Locating ...";
        if(request.isNetworkError){
            Debug.Log("error : "+request.error);
        }else{

            if(request.isDone){
                Country res = JsonUtility.FromJson<Country>(request.downloadHandler.text);
                country = res.country;
                Debug.Log(country);
            }
        }
    }
    
}
