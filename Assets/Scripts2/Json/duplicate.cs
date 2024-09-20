using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using Newtonsoft.Json.Linq;
using SimpleJSON;
public class duplicate : MonoBehaviour
{
    
    private Text text;
    
    
    void Start()
    {

        
            

    }
    //Generating the text of DAY
    public void Day(string i, GameObject Parent)
    {
        Font arial;
        arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        GameObject textGO = new GameObject("Day");
        //The text will be a child of the variable Parent 
        textGO.transform.parent = Parent.transform;
        textGO.AddComponent<Text>();
        text = textGO.GetComponent<Text>();
        text.font = arial;
        text.text = i;
        text.fontSize = 15;
        
        text.color = Color.black;
        text.alignment = TextAnchor.MiddleCenter;
        RectTransform rectTransform;
        rectTransform = text.GetComponent<RectTransform>();
        //Text Position
        rectTransform.localPosition = new Vector3(-52, 0, 0);
        rectTransform.sizeDelta = new Vector2(127, 33);
        CorrectTextBlur(text);
    }

    public void CreateButton(GameObject Parent, int i, JObject jsonObject)
    {
        GameObject button = new GameObject("Button "+i);
        button.transform.parent = Parent.transform;
        button.AddComponent<RectTransform>();
        button.AddComponent<Button>();
        button.transform.position = new Vector3(0, 0, 0);
        button.GetComponent<RectTransform>().sizeDelta= new Vector2(127, 33);
        Button btn = Parent.AddComponent<Button>();//Create transparent Button for the event
        btn.onClick.AddListener(delegate { TaskOnClick(i, jsonObject); });
        
    }

    public void TaskOnClick(int i, JObject jsonObject)
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        
        int ButtonIndex = GetButtonIndex(i, name);


        int j = 0;

        foreach (object element in jsonObject["data"][ButtonIndex]["translations"]["fr"]["content"])
        {
            if (string.Equals((string)jsonObject["data"][ButtonIndex]["translations"]["fr"]["content"][j]["type"], "gallery"))
            {
               string  Url = (string)jsonObject["data"][ButtonIndex]["translations"]["fr"]["content"][j]["data"]["items"][0]["url"];
                Application.OpenURL(Url);
            }
            j++;
        }
        
       
    }

    public int GetButtonIndex(int i, string name)
    {
        
        string str = name;
        int l = name.Length;
        if (i < 99)
        {
            str = name.Substring(l - 2, 2);
            if (string.Equals(str[0], ' '))
            {
                str = name.Substring(l - 1, 1);
            }
            else
            {
                str = name.Substring(l - 2, 2);
            }
        }
        if (i > 99)
        {
            str = name.Substring(l - 3, 3);
            if (string.Equals(str[0], ' '))
            {
                str = name.Substring(l - 2, 2);
                if (string.Equals(str[0], ' '))
                {
                    str = name.Substring(l - 1, 1);
                }
            }

        }
        int ButtonIndex = Int32.Parse(str);
        return ButtonIndex;
    }
    public void Title(string str, GameObject Parent)
    {
        Font arial;
        arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        GameObject textGO = new GameObject("Title");
        textGO.transform.parent = Parent.transform;
        textGO.AddComponent<Text>();
        text = textGO.GetComponent<Text>();
        text.font = arial;
        text.text = str;
        text.fontStyle = FontStyle.Bold;
        text.fontSize = 6;

        int j = 25;
        //Return to line if text is too long 
        if (60 < str.Length)
        {
            text.fontSize = 4;
            text.text.Substring(0, 40);
            text.text+= "...";
        }
        ReturnToLine(j, text.text);
        

            
            text.color = Color.black;
        text.alignment = TextAnchor.UpperLeft;
        RectTransform rectTransform;
        rectTransform = text.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(-33, 13, 0);
        rectTransform.sizeDelta = new Vector2(127, 33);
        CorrectTextBlur(text);
    }



    public void Month(string str, GameObject Parent)
    {
        Font arial;
        arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        GameObject textGO = new GameObject("Month");
        textGO.transform.parent = Parent.transform;
        textGO.AddComponent<Text>();
        text = textGO.GetComponent<Text>();
        text.font = arial;
        text.text = str;
        text.fontStyle = FontStyle.Bold;
        text.fontSize = 6;

        text.color = Color.black;
        text.alignment = TextAnchor.UpperLeft;
        RectTransform rectTransform;
        rectTransform = text.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(-51, 13, 0);
        rectTransform.sizeDelta = new Vector2(127, 33);
        CorrectTextBlur(text);

        //Dictionnary contains the abbreviation of Months to show 
        var months = new Dictionary<string, string>(){
            {"01","JAN"},
            {"02","FEV"},
            {"03","MAR"},
            {"04","AVR"},
            {"05","MAI"},
            {"06","JUN"},
            {"07","JUL"},
            {"08","AOU"},
            {"09","SEP"},
            {"10","OCT"},
            {"11","NOV"},
            {"12","DEC"}
            };
        foreach (var month in months)
        {
            if ((text.text).CompareTo(month.Key) == 0)
            {
                text.text = month.Value;
            }
        }   
    }

    
    public void StartEndTime(string str1, string str2, GameObject Parent)
    {
        Font arial;
        arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        GameObject textGO = new GameObject("StartEndTime");
        textGO.transform.parent = Parent.transform;
        textGO.AddComponent<Text>();
        text = textGO.GetComponent<Text>();
        text.font = arial; 
        text.text = "De"+str1+" à "+str2;
        text.fontSize = 6;
        
        text.color = Color.black;
        text.alignment = TextAnchor.MiddleCenter;
        RectTransform rectTransform;
        rectTransform = text.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(-15, -3, 0);
        rectTransform.sizeDelta = new Vector2(127, 33);
        CorrectTextBlur(text);
    }
    public string ByWho(string CodingSchool, string FabLab, string OrangeFab)
    {
        //Converting from String to Bool 
        bool CS =  bool.Parse(CodingSchool);
        bool FB =  bool.Parse(FabLab);
        bool OF =  bool.Parse(OrangeFab);

        string bywho = "";
        

       
        if (CS)
        {
            bywho += "Coding School";


        }
        if (FB)
        {
            bywho += " Fab Lab";


        }
        if (OF)
        {
            bywho += " Orange Fab";


        }
        
        if((!CS)&&(!FB)&&(!OF))
        {
            bywho = "";
        }

        return bywho;
    }
    //Correcting the Text Size and Blur 
    public void CorrectTextBlur(Text text)
    {
        const int ScaleValue = 10;
         text.fontSize = text.fontSize * ScaleValue;

        text.transform.localScale = text.transform.localScale / ScaleValue;

        text.horizontalOverflow = HorizontalWrapMode.Overflow;
        text.verticalOverflow = VerticalWrapMode.Overflow;
    }
    public void ReturnToLine(int Position, string str)
    {
        bool spaceFound = false;
        while ((Position < str.Length) && (spaceFound == false))
        {

            if (str[Position].Equals(' '))
            {
                text.text = str.Insert(Position, "\n");
                spaceFound = true;
                text.fontSize = 6;
            }
            Position++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
