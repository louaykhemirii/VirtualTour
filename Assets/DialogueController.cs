using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using static DialogueObject;

public class DialogueController : MonoBehaviour
{
    public int c = 1;
    private string text1;
    private string text2;
    private string text3;

    private Dialogue curDialogue;
    private Node curNode;

    private string ext;

    public delegate void NodeEnteredHandler(Node node);

    public event NodeEnteredHandler onEnteredNode;
    string myFilePath, myFilePath2, myFilePath3;
    string fileID, fileID2, fileID3;
        string str, str2, str3;
   string fileName = "scenario1";
      string  fileName2 = "scenario2";
      string  fileName3 = "scenario3";
    public Node GetCurrentNode()
    {
        return curNode;
    }
    public IEnumerator Start()
    {
        string fileName = "scenario1";
        string fileName2 = "scenario2";
        string fileName3 = "scenario3";
        myFilePath = Application.streamingAssetsPath + "/Resources/" + fileName + ".txt";
        myFilePath2 = Application.streamingAssetsPath + "/Resources/" + fileName2 + ".txt";
        myFilePath3= Application.streamingAssetsPath + "/Resources/" + fileName3 + ".txt";
        string url1 = "https://virtuelodc-backend.herokuapp.com/onecharacter/61b31b6ee5e82cd2a841a10b";
        WWW a = new WWW(url1);
        yield return a;
        if (a.error != null)
        {
            Debug.Log("Error .. " + a.error);
        }
        else
        {
            yield return new WaitForSeconds(2);
            JObject jsonfile = JObject.Parse(a.text);
            str = jsonfile.ToString();
            fileID = (string)jsonfile["characters"]["chat"];
            Debug.Log("FileID "+fileID);

        }

        string url2 = "https://virtuelodc-backend.herokuapp.com/onecharacter/61b31b5ae5e82cd2a841a109";
        WWW b = new WWW(url2);
        yield return b;
        if (b.error != null)
        {
            Debug.Log("Error .. " + b.error);
        }
        else
        {
            yield return new WaitForSeconds(2);
            JObject jsonfile2 = JObject.Parse(b.text);
            str2 = jsonfile2.ToString();
            fileID2 = (string)jsonfile2["characters"]["chat"];
            Debug.Log("FileID2" + fileID2);

        }

        string url3 = "https://virtuelodc-backend.herokuapp.com/onecharacter/61b31b93404bbbd30cb818e6";
        WWW c = new WWW(url2);
        yield return c;
        if (c.error != null)
        {
            Debug.Log("Error .. " + c.error);
        }
        else
        {
            yield return new WaitForSeconds(2);
            JObject jsonfile3 = JObject.Parse(b.text);
            str3 = jsonfile3.ToString();
            fileID3 = (string)jsonfile3["characters"]["chat"];
            Debug.Log("FileID3" + fileID3);

        }

        WWW d = new WWW("https://virtuelodc-backend.herokuapp.com/" + "/" + fileID);
        yield return d;
        if (d.error != null)
        {
            Debug.Log("Error .. " + d.error);
        }
        else if(d.isDone)
        {
            Debug.Log("isDone1" + d.isDone);
            Debug.Log("Found ... ==>" + d.text + "<==");
            string textscenario = (string)d.text;
            File.WriteAllText(myFilePath, textscenario);
        }
        else
        {
            
            Debug.Log("isDone2" + d.isDone);
            Debug.Log("Found ... ==>" + d.text + "<==");
            string textscenario = (string)d.text;
            File.WriteAllText(myFilePath, textscenario);
        }
        WWW e = new WWW("https://virtuelodc-backend.herokuapp.com/" + "/" + fileID2);
        yield return e;
        if (e.error != null)
        {
            Debug.Log("Error .. " + e.error);
        }
        else 
        {
            yield return new WaitForSeconds(2);
            Debug.Log("Found ... ==>" + e.text + "<==");
            string textscenario = (string)d.text;
            File.WriteAllText(myFilePath2, textscenario);
        }

        WWW f = new WWW("https://virtuelodc-backend.herokuapp.com/" + "/" + fileID3);
        yield return f;
        if (f.error != null)
        {
            Debug.Log("Error .. " + f.error);
        }
        else
        {
            yield return new WaitForSeconds(1);
            Debug.Log("Found ... ==>" + f.text + "<==");
            string textscenario = (string)f.text;
            File.WriteAllText(myFilePath3, textscenario);
        }

        Debug.Log("On start" + fileName);
    }
    

    public void InitializeDialogue()
    {
        string fileName = "scenario1";
        string fileName2 = "scenario2";
        string fileName3 = "scenario3";
        
        Debug.Log("application"+Application.streamingAssetsPath + "/Resources/" + fileName + ".txt");
        if (c == 0)
        {
            ext = File.ReadAllText(Application.streamingAssetsPath + "/Resources/" + fileName + ".txt");
            //ext = text1;
            //ext = ext.Replace("-","\r\n");
            ext = ext.Replace("\n", "\r\n");
            Debug.Log("desc num 0");
            Debug.Log("C = " + c);
            Debug.Log("=====> " + ext);
        }
        if (c == 1)
        {
            ext = File.ReadAllText(Application.streamingAssetsPath + "/Resources/" + fileName3 + ".txt");
            //ext = text2;
            //ext = ext.Replace("-","\r\n");
            ext = ext.Replace("\n", "\r\n");
            Debug.Log("desc num 1");
            Debug.Log("C = " + c);
            Debug.Log("=====> " + ext);
        }
        if (c == 2)
        {
           // string extValid = File.ReadAllText(Application.streamingAssetsPath + "/Resources/" + fileName3 + ".txt");
            
            ext = File.ReadAllText(Application.streamingAssetsPath + "/Resources/" + fileName2 + ".txt");
            //ext = text3;
            //ext = ext.Replace("-","\r\n");
            ext = ext.Replace("\n", "\r\n");
         //   extValid = extValid.Replace("\n", "\r\n");
            print("AAAAAAAAAAAAAAAAAAAA = " + ext);

           // print("BBBBBBBBBBBBBBBBBBBB = " + extValid);
            Debug.Log("desc num 2");
            Debug.Log("C = " + c);
            Debug.Log("=====> " + ext);
        }

        curDialogue = new Dialogue(ext);
        curNode = curDialogue.GetStartNode();
        onEnteredNode(curNode);
    }

    public List<Response> GetCurrentResponses()
    {
        return curNode.responses;
    }

    public void ChooseResponse(int responseIndex)
    {
        string nextNodeID = curNode.responses[responseIndex].destinationNode;
        Node nextNode = curDialogue.GetNode(nextNodeID);
        curNode = nextNode;
        onEnteredNode(nextNode);
    }
}