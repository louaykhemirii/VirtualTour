using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using Newtonsoft.Json.Linq;
using UnityEngine.UI;
public class MyBehavior : MonoBehaviour
{

    public GameObject Email;
    public InputField Password;
    public GameObject LoginError;
    public GameObject Success;
    public GameObject LoginInterface;
    public IntroAnimation camera;
    string user;
    string pass;
    string firstName;
    string lastName;
    string gender;
    bool connected = false;
    public void ConnectButton()
    {
        StartCoroutine(Upload());
    }
    public void ok()
    {
        Success.SetActive(false);

        
    }
    IEnumerator Upload()
    {
        
         user=Email.GetComponent<UnityEngine.UI.Text>().text;
         pass = Password.text;
        
        Debug.Log("the email is " + user);
        Debug.Log("the password is " + pass);
        WWWForm form = new WWWForm();
        form.AddField("email", user);
        form.AddField("password",pass);
        UnityWebRequest www = UnityWebRequest.Post("https://www.orangedigitalcenters.com/api/v1/user/auth/login ", form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
            LoginError.SetActive(true);

        }
        else
        {
            Success.SetActive(true);
            LoginError.SetActive(false);
            LoginInterface.SetActive(false);
            Debug.Log("Form upload complete!");
            Debug.Log(www.result);
            Debug.Log("Post request complete!" + " Response Code: " + www.responseCode);
            string responseText = www.downloadHandler.text;
            Debug.Log("Response Text:" + responseText);
            JObject json = JObject.Parse(responseText);

            firstName = (string)json["data"]["user"]["firstName"];
           lastName = (string)json["data"]["user"]["lastName"];
            gender= (string)json["data"]["user"]["gender"];
            connected = true;
        }
    }
    public void close()
    {
        LoginInterface.SetActive(false);
        camera.ReturnToOldCamera();
        LoginError.SetActive(false);
    }
    public bool GetConnected()
    {
        return connected;
    }
    public void ShowLoginPanel()
    {
        
        LoginInterface.SetActive(true) ;
        
    }
    public string GetPass()
    {
        return pass; 
    }
    public string GetEmail()
    {
        return user;
    }
    public string GetLastName()
    {
        return lastName;
    }
    public string GetFirstName()
    {
        return firstName;
    }
    public string GetGender()
    {
        return gender;
    }
}
