using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using Newtonsoft.Json.Linq;
using UnityEngine.UI;

public class Onclick_Text_Chatbot : MonoBehaviour
{
   public  bool clicked = false;
   public  GameObject Text;
    MyBehavior Login;
    public GameObject message;
    string firstName;
     string lastName;
     string gender;
     
    
    // Start is called before the first frame update
    void Start()
    {
       
    }
    IEnumerator Upload()
    {
        message.SetActive(true);
        Login = GameObject.Find("Login").GetComponent<MyBehavior>();
        string strEmail = Login.GetEmail();
         firstName = Login.GetFirstName();
         lastName = Login.GetLastName();
        gender = Login.GetGender();
        print("this is your Email" + strEmail);



        WWWForm form = new WWWForm();
        form.AddField("question", Text.GetComponent<UnityEngine.UI.Text>().text);
        form.AddField("nom",firstName);
        form.AddField("prenom", lastName);
        form.AddField("civility", gender);
        form.AddField("email", strEmail);
        form.AddField("phone", "22 222 222");


        using (UnityWebRequest www2 = UnityWebRequest.Post("https://virtuelodc-backend.herokuapp.com/quess", form))
        {
            yield return www2.SendWebRequest();

            if (www2.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www2.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
            }
        }
        yield return new WaitForSeconds(2f);
        message.SetActive(false);
    }
    public void clique ()
    {
        
        StartCoroutine(Upload());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
