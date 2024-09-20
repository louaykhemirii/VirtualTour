using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using System.IO;


public class testfile : MonoBehaviour
{
/*
    public static int x3;
    
    public static string esp;
    public static string esp2;
    public static string esp3;


    [SerializeField] string Lien1;
    [SerializeField] string Lien2;
    [SerializeField] string Lien3;
    [SerializeField] string JsonLink;


    
    string jsonfile;

    
    string country;
    // Start is called before the first frame update
   

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
                //Debug.Log(country);
            }
        }
    }
    
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        country="";
        StartCoroutine(GetCountry());
    }
         public void Start()
      {
          Directory.CreateDirectory(Application.streamingAssetsPath + "/Resources/");
          
        
         //StartCoroutine(Check());
         try{
            //StartCoroutine(GetRequest(Lien1,1));
            //StartCoroutine(GetRequest(Lien2,2));
            //StartCoroutine(GetRequest(Lien3,3));
            
            Debug.Log("country ="+country);
            StartCoroutine(GetJson(JsonLink+"?country="+country));

            jsonfile = File.ReadAllText(Application.streamingAssetsPath+"/Resources/"+"characters"+".json");
            Debug.Log(jsonfile);
            Characters charactersInJson = JsonUtility.FromJson<Characters>(jsonfile);
            int i = 1;
            foreach(Character cha in charactersInJson.characters){
                StartCoroutine(GetRequest("http://localhost:3001/"+cha.chat,i));
                Debug.Log("int i = "+i);
                i++;
            
                }


         }catch(System.Exception){
                Debug.Log("Server is down!");
         }
         
         
         SceneManager.LoadScene(1);
      }
     
    
     IEnumerator GetRequest(string uri,int x)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    
                    
                    if(x==1){
                        Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                        string savePath =  Application.streamingAssetsPath+"/Resources/"+"num1"+".txt";
                        File.WriteAllText(savePath, webRequest.downloadHandler.text);
                        //esp = webRequest.downloadHandler.text;
                    }
                    if(x==2){
                        Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                         string savePath =  Application.streamingAssetsPath+"/Resources/"+"num2"+".txt";
                         File.WriteAllText(savePath, webRequest.downloadHandler.text);
                        //esp2=webRequest.downloadHandler.text;
                    }else{
                        Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                        string savePath = Application.streamingAssetsPath+"/Resources/"+"num3"+".txt"; 
                        File.WriteAllText(savePath, webRequest.downloadHandler.text);
                        //esp3= webRequest.downloadHandler.text;
                    }

                    x3 = x;
                    //esp=ext;
                    break;
            }
        }
    }

IEnumerator GetJson(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();
            Debug.Log("the uri with para = "+uri);

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                        Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                        string savePath =  Application.streamingAssetsPath+"/Resources/"+"characters"+".json";
                        File.WriteAllText(savePath, webRequest.downloadHandler.text);
                        //esp = webRequest.downloadHandler.text;
                    
                    break;
            }
        }
    }

       */  
}

