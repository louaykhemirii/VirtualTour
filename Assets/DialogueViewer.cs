using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static DialogueObject;
using UnityEngine.Events;
using System;
using System.Runtime.InteropServices;
using Proyecto26;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;

public class DialogueViewer : MonoBehaviour
{
    [SerializeField] Transform parentOfResponses;
    [SerializeField] Transform parent;
    [SerializeField] Button prefab_btnResponse;
    [SerializeField] GameObject prefab1;
    [SerializeField] GameObject prefab2;
    [SerializeField] GameObject prefab11;
    [SerializeField] GameObject prefab22;
    [SerializeField] GameObject inp; 
    [SerializeField] UnityEngine.UI.Text txtNodeDisplay;
    [SerializeField] DialogueController dialogueController;
    [SerializeField] DialogueController dialogueController2;
    [SerializeField] DialogueController dialogueController3;
    [SerializeField] GameObject warning;
    [SerializeField] Transform p;
    [SerializeField] int di;
    public DateTime starttime;
    public DateTime endtime;
    Transform options;
    DialogueController controller;
    static DialogueController c2;
    public int discnumber;
    int i = 0,x1=-1,x2=0;
    int f= 0;
    string fileName;
    string myFilePath;
    bool Question = false;
    changeloc c;
    string str;
    string fileID;
    static List<diars> dialo = new List<diars>();
    [DllImport("__Internal")]
    
    private static extern void openPage(string url);

    private void Start()
    {
        
        //controller = dialogueController;
        //controller.onEnteredNode += OnNodeEntered;
        //controller.InitializeDialogue();


        //// Start the dialogue
        //var curNode = controller.GetCurrentNode();
        options = parentOfResponses;
        
       
    }
    
    private void Update()
    {
        Debug.Log("On update"+fileName);
        if (aff.x == 1 && f != 1)
        {
            foreach (Transform child in p)
            {
                if (child.tag!="emp")
                {
                Destroy(child.gameObject);
                }

            }
            
            controller = dialogueController;
            controller.onEnteredNode += OnNodeEntered;
            controller.InitializeDialogue();
            


            // Start the dialogue
            var curNode = controller.GetCurrentNode();
            f = 1;
            discnumber = 1;
            di = discnumber;

        }
        if (aff.x == 2 && f != 2)
        {
            foreach (Transform child in p)
            {
                if (child.tag != "emp")
                 {
                Destroy(child.gameObject);
                 }

            }
            
            controller = dialogueController2;
            controller.onEnteredNode += OnNodeEntered;
            controller.InitializeDialogue();

            discnumber = 2;
            di = discnumber;
            // Start the dialogue
            var curNode = controller.GetCurrentNode();
            f = 2;
        }
        if (aff.x == 3 && f != 3)
        {
            foreach (Transform child in p)
            {
                if (child.tag != "emp")
                {
                    Destroy(child.gameObject);
                }

            }
            
            //Instantiate(options,p);
            controller = dialogueController3;
            controller.onEnteredNode += OnNodeEntered;
            controller.InitializeDialogue();
            discnumber = 3;
            di = discnumber;
            
            // Start the dialogue
            var curNode = controller.GetCurrentNode();
            f = 3;
        }
    }
    
    public int getdiscnumber()
    {
        return di;
    }
    public static void KillAllChildren(UnityEngine.Transform parent)
    {
        UnityEngine.Assertions.Assert.IsNotNull(parent);
        for (int childIndex = parent.childCount - 1; childIndex >= 0; childIndex--)
        {
            UnityEngine.Object.Destroy(parent.GetChild(childIndex).gameObject);
        }
    }

    private void OnNodeSelected(int indexChosen)
    {
        Debug.Log("Chose: " + indexChosen);
        controller.ChooseResponse(indexChosen);
    }

    private void OnNodeEntered(Node newNode)
    {
        
        if (newNode.tags.Contains("START"))
        {
            Debug.Log("Start disc at :" + DateTime.Now);
            starttime = DateTime.Now;
        }
        if (newNode.tags.Contains("END"))
        {
            Debug.Log("End disc at :" + DateTime.Now);
            endtime = DateTime.Now;
        }

        Debug.Log("Entering node: " + newNode.title);
        if ((newNode.title).Contains("questions"))
        {
            Question = true;   
        }
        if(Question)
        {
            print("you can send this response " + newNode.title);
        }
        txtNodeDisplay.text = newNode.text;
        Debug.Log("this is txt node display" + txtNodeDisplay.text);
        diars d = new diars(newNode.title, txtNodeDisplay.text,starttime,endtime);
        dialo.Add(d);
        
        if (i != 0 && newNode.title != "End"&& newNode.title!="Send")
        {
            //if (newNode.title.Length > 35)
            //{
                var responce = Instantiate(prefab1, parent);
                if(newNode.title.IndexOf("==")!=-1){
                    responce.GetComponentInChildren<UnityEngine.UI.Text>().text = newNode.title.Split(new [] { "==" }, StringSplitOptions.RemoveEmptyEntries)[0];
                print("this is response " + responce.GetComponentInChildren<UnityEngine.UI.Text>().text);
                }else{
                    responce.GetComponentInChildren<UnityEngine.UI.Text>().text = newNode.title;
                    
                }
                
                //responce.transform.SetAsFirstSibling();
                responce.transform.SetSiblingIndex(x1);
                warning.SetActive(false);
            //}
            //else
            //{
            //    var responce = Instantiate(prefab11, parent);
            //    responce.GetComponentInChildren<UnityEngine.UI.Text>().text = newNode.title;
            //    //responce.transform.SetAsFirstSibling();
            //    responce.transform.SetSiblingIndex(x1);
            //    warning.SetActive(false);
            //}
            
            
            


        }
        if (txtNodeDisplay.text != "")
        {
            //if (txtNodeDisplay.text.Length > 35)
            //{
                var responce2 = Instantiate(prefab2, parent);
                responce2.GetComponentInChildren<UnityEngine.UI.Text>().text = txtNodeDisplay.text;
                //responce2.transform.SetAsFirstSibling() ;
                responce2.transform.SetSiblingIndex(x2);
            //}
            //else
            //{
            //    var responce2 = Instantiate(prefab22, parent);
            //    responce2.GetComponentInChildren<UnityEngine.UI.Text>().text = txtNodeDisplay.text;
            //    //responce2.transform.SetAsFirstSibling() ;
            //    responce2.transform.SetSiblingIndex(x2);
            //}
            
            
            
        }

        i++;
        x1+=2;
        x2 += 2;
        KillAllChildren(parentOfResponses);
        for (int i = newNode.responses.Count - 1; i >= 0; i--)
        {
            parentOfResponses.transform.SetAsLastSibling();
            int currentChoiceIndex = i;
            var response = newNode.responses[i];
            var responceButton = Instantiate(prefab_btnResponse, parentOfResponses);
                if(response.displayText.IndexOf("==")!=-1){
                     responceButton.GetComponentInChildren<UnityEngine.UI.Text>().text = response.displayText.Split(new [] { "==" }, StringSplitOptions.RemoveEmptyEntries)[1];
                }else{
                     responceButton.GetComponentInChildren<UnityEngine.UI.Text>().text = response.displayText;
                }


           
            if(response.displayText == "Send")
            {
                inp.SetActive(true);
                responceButton.onClick.AddListener(delegate {
                    var responce = Instantiate(prefab2, parent);
                    responce.GetComponentInChildren<UnityEngine.UI.Text>().text ="your name is " + inp.GetComponent<InputField>().text;
                    //responce.transform.SetAsFirstSibling();
                    //responce.GetComponentInChildren<UnityEngine.UI.Text>().text ="ttttttttt";
                    responce.transform.SetSiblingIndex(x1);
                    inp.SetActive(false);
                }); 
            }
            if(response.displayText == "ODC"){
                responceButton.onClick.AddListener(delegate{
                    
                    changeloc.name = "ODC";
                    changeloc.ii = 1;
                    
                    


                });
            }
            if(response.displayText == "FabLab"){
                responceButton.onClick.AddListener(delegate{
                    
                    changeloc.name = "FabLab";
                    changeloc.ii = 1;
                    


                });
            }
            if(response.displayText == "Fab"){
                responceButton.onClick.AddListener(delegate{
                    
                     changeloc.name = "Fab";
                     changeloc.ii = 1;
                    


                });
            }
            //responceButton.transform.SetAsLastSibling();
            responceButton.onClick.AddListener(delegate { OnNodeSelected(currentChoiceIndex); });
            
        }

        if (newNode.tags.Contains("END"))
        {
            Debug.Log("End!");
        }
    }
    

    public static void affdialo()
    {
        List<string> allst1 = new List<string>();
        List<string> allst2 = new List<string>();
        DateTime start4 = dialo[0].getstart() ;
        DateTime end4 = dialo[dialo.Count - 1].getend();
        foreach (diars di in dialo)
        {
            Debug.Log(di.getdia());
            Debug.Log(di.getres());
            Debug.Log(di.getstart());
            Debug.Log(di.getend());
            allst1.Add(di.getdia());
            allst2.Add(di.getres());
            //start4 = di.getstart();
            //end4 = di.getend();

            //test t = new test(di.getdia(), di.getres(), di.getstart().ToString(), di.getend().ToString());
            //diars d1 = new diars(di.getdia(), di.getres(), di.getstart(),di.getend());
            //RestClient.Post("https://test-5b3e6-default-rtdb.europe-west1.firebasedatabase.app/.json", t);
        }
        string combindedString = string.Join("/", allst1);
        string combindedString2 = string.Join("/", allst2);
        test t = new test(combindedString, combindedString2, start4.ToString(), end4.ToString());
        RestClient.Post("https://test-5b3e6-default-rtdb.europe-west1.firebasedatabase.app/.json", t);
    }
    public static List<diars> rdiars()
    {
        return dialo;
    }
}
public class test{
    public string Bot ;
    public string User ;
    public string Starttime;
    public string EndTime;
    public test(string t1,string t2 , string t3,string t4)
    {
        this.Bot = t1;
        this.User = t2;
        this.Starttime = t3;
        this.EndTime = t4;
    }
}

public class diars
{
    string dia;
    string res;
    DateTime start;
    DateTime end;

    public diars(string s,string s2,DateTime st, DateTime en)
    {
        start = st;
        end = en;
        dia = s;
        res = s2;
    }
    public string getdia()
    {
        return this.dia;

    }

    public string getres()
    {
        return this.res;

    }

    public DateTime getstart()
    {
        return this.start;

    }

    public DateTime getend()
    {
        return this.end;

    }



}
