using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class aff : MonoBehaviour
{
    //l'objet de discussion de chatbot
    public GameObject g;
    public static int x;
    public static int check = 0;
    public int x2;
    public MyBehavior connection;
    public IntroAnimation camera;
    
    //GameObject player;
    [SerializeField] Transform c;
    Transform initlocation;
    bool v1= false, v2= false, v3 = false;
    Vector3 initpos;
    Quaternion initrotation;
    private void Start()
    {
        foreach (Transform child in GameObject.FindGameObjectWithTag("Canvas").transform)
        {
            child.gameObject.SetActive(false);
        }
        initlocation = GameObject.FindGameObjectWithTag("Canvas").transform;
        initpos = Camera.main.transform.position;
        initrotation = Camera.main.transform.rotation;
    }
  
   
    public void OnMouseOver()
    {
        
        if (Input.GetMouseButtonDown(1) )
        {

           
            if (connection.GetConnected())
            {
                check = 1;
                //player = null;

                foreach (Transform child in GameObject.FindGameObjectWithTag("Canvas").transform)
                {
                    if (child.gameObject.GetComponent<DialogueViewer>().discnumber == 1)
                    {
                        v1 = true;
                    }
                    if (child.gameObject.GetComponent<DialogueViewer>().discnumber == 2)
                    {
                        v2 = true;
                    }
                    if (child.gameObject.GetComponent<DialogueViewer>().discnumber == 3)
                    {
                        v3 = true;
                    }
                }

                if (v1 == false && x2 == 1)
                {
                    GameObject player = GameObject.Instantiate(g, GameObject.FindGameObjectWithTag("Canvas").transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                    int v = player.GetComponent<DialogueViewer>().discnumber;


                    Debug.Log("this is v " + v);
                    player.SetActive(true);
                }
                if (v2 == false && x2 == 2)
                {
                    GameObject player = GameObject.Instantiate(g, GameObject.FindGameObjectWithTag("Canvas").transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                    int v = player.GetComponent<DialogueViewer>().discnumber;


                    Debug.Log("this is v " + v);
                    player.SetActive(true);
                }
                if (v3 == false && x2 == 3)
                {
                    GameObject player = GameObject.Instantiate(g, GameObject.FindGameObjectWithTag("Canvas").transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                    int v = player.GetComponent<DialogueViewer>().discnumber;


                    Debug.Log("this is v " + v);
                    player.SetActive(true);
                }


                //------------------------------------------------------------


                if (v1 == true && x2 == 1)
                {
                    foreach (Transform child in GameObject.FindGameObjectWithTag("Canvas").transform)
                    {
                        if (child.gameObject.GetComponent<DialogueViewer>().discnumber == 1)
                        {
                            child.gameObject.SetActive(true);
                        }

                    }
                }
                if (v2 == true && x2 == 2)
                {
                    foreach (Transform child in GameObject.FindGameObjectWithTag("Canvas").transform)
                    {
                        if (child.gameObject.GetComponent<DialogueViewer>().discnumber == 2)
                        {
                            child.gameObject.SetActive(true);
                        }

                    }
                }
                if (v3 == true && x2 == 3)
                {
                    foreach (Transform child in GameObject.FindGameObjectWithTag("Canvas").transform)
                    {
                        if (child.gameObject.GetComponent<DialogueViewer>().discnumber == 3)
                        {
                            child.gameObject.SetActive(true);
                        }

                    }
                }

                look.target = transform.position;
                look.t = transform;
                x = x2;
                //string path = "Assets/Resources/test.txt";
                //string path2 = "Assets/Resources/bossdialogue.txt";
                ////Write some text to the test.txt file
                //File.WriteAllText(path2, "");
                //StreamWriter writer = new StreamWriter(path2, true);
                //StreamReader reader = new StreamReader(path);
                //writer.WriteLine(reader.ReadToEnd());

                //writer.Close();

                ////Re-import the file to update the reference in the editor
                ////UnityEditor.AssetDatabase.ImportAsset(path); 
                //TextAsset asset = (TextAsset)Resources.Load("bossdialogue");

                ////Print the text from the file
                //Debug.Log(asset.text);
                //setactivefalse();
            }
            else
            {
                camera.SetCameraForLogin();
                
                connection.ShowLoginPanel();
                
            }
        }
        
    }
    
    void setactivefalse()
    {
        if (GameObject.FindGameObjectWithTag("Canvas").transform.childCount >= 1)
        {
            foreach (Transform child in GameObject.FindGameObjectWithTag("Canvas").transform)
            {
                child.gameObject.SetActive(false);
            }
        }
    }
    

    
}
