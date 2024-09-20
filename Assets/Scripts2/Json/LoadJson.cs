using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using TMPro;
using UnityEngine.Networking;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using UnityEngine.UI;
public class LoadJson : MonoBehaviour
{
    public Dropdown m_Dropdown;
    public Button EventButton;
    string url = "https://www.orangedigitalcenters.com/api/v1/client/country/";
    string title, content, Startdate, EndDate, Day, Month, year, codingSchool, fabLabSolidaire, orangeFab, StartTime, EndTime, Url;
    public duplicate transform;
    public GameObject ParentPanel; //Parent Panel you want the new Images to be children of
    // Sample JSON for the following script has attached.
    IEnumerator Start()
    {
        url += check(m_Dropdown.value) + "/event";
        WWW www = new WWW(url);
        yield return www;
        if (www.error == null)
        {

            GetJson(www);

        }
        else
        {
            Debug.Log("ERROR: " + www.error);
        }
    }
    //Check from the Drop Down which Country the user select 
    public string check(int value)
    {
        string Country = "";
        switch (value)
        {
            case 1:
                Country = "TN";
                break;
            case 2:
                Country = "MA";
                break;
            case 3:
                Country = "IC";
                break;
            case 4:
                Country = "SL";
                break;
            case 5:
                Country = "EG";
                break;
            case 6:
                Country = "SN";
                break;
            case 7:
                Country = "ML";
                break;
            case 8:
                Country = "ET";
                break;
            case 9:
                Country = "MG";
                break;
            case 10:
                Country = "LR";
                break;
            case 11:
                Country = "JO";
                break;
            case 12:
                Country = "GB";
                break;
            case 13:
                Country = "BF";
                break;
            case 14:
                Country = "CM";
                break;
            case 15:
                Country = "BW";
                break;
        }
        return Country;
    }

    public void GetJson(WWW www)
    {
        url += check(m_Dropdown.value) + "/event";
        JObject jsonObject = JObject.Parse(www.text);


        //(english)Egypte EG,Serra lione SL, Cameroon CM 
        //(francais) Mali  , morocco MA ,Burkina fassau BF 
        //(vide) Botswana BW,Senegal SN, Ethiobia ET, Madagascar MG,Liberia LR,Jordan JO,Botswana BW
        //(Error) Ginea Bissau GW,
        string Langue = "";
        string Country = url.Substring(59, 2);
        //Filtre countries who speaks English and frensh
        if ((Country == "EG") || (Country == "SL") || (Country == "CM"))
        {
            Langue = "en";
        }
        else
        {
            Langue = "fr";
        }
        int i = 0;


        foreach (object element in jsonObject["data"])
        {


            title = (string)jsonObject["data"][i]["translations"][Langue]["title"];
            //content = (string)jsonObject["data"][i]["translations"]["fr"]["content"][0]["data"]["content"];
            Startdate = (string)jsonObject["data"][i]["startDate"];
            EndDate = (string)jsonObject["data"][i]["endDate"];

            Month = Startdate.Substring(0, 2);//substring the 2 characters defines the month from StartDate
            Day = Startdate.Substring(3, 2);//substring the 2 characters defines the Day from StartDate
            year = Startdate.Substring(6, 2);
            StartTime = Startdate.Substring(10, 6);
            EndTime = EndDate.Substring(10, 6);
            codingSchool = (string)jsonObject["data"][i]["creator"]["codingSchool"];
            fabLabSolidaire = (string)jsonObject["data"][i]["creator"]["fabLabSolidaire"];
            orangeFab = (string)jsonObject["data"][i]["creator"]["orangeFab"];
            print(title);
            print("start date is " + Startdate);
            print(i);
            print("this is the day " + Day);
            print("content number" + i);
            print("this :" + codingSchool.GetType() + fabLabSolidaire + orangeFab);

            //string contentFiltred = StripHTML(content);
            //contentFiltred = nbsp(contentFiltred);
            //print(contentFiltred);

            //generate GameObject 
            GameObject NewObj = new GameObject("Event  " + i); //Create the GameObject (we will add text in this GameObject)
            Image NewImage = NewObj.AddComponent<Image>(); //Add the Image Component script
            NewImage.rectTransform.sizeDelta = new Vector2(130, 33);

            NewObj.GetComponent<RectTransform>().SetParent(ParentPanel.transform); //Assign the newly created Image GameObject as a Child of the Parent Panel.

            NewObj.SetActive(true); //Activate the GameObject


            //transform is the name of the class duplicate
            transform.CreateButton(NewObj, i, jsonObject);//Creating buttons for each event
            transform.Day(Day, NewObj);//Calling the method Day from the class duplicate to set the Day text in the container (NewObj)
            transform.Title(title, NewObj);
            transform.Month(Month, NewObj);
            transform.StartEndTime(StartTime, EndTime, NewObj);
            //transform.ByWho(codingSchool, fabLabSolidaire, orangeFab, NewObj);

            i++;
        }

    }
    //Delete the HTML tags (<..>) from a string 
    public static string StripHTML(string input)
    {
        return Regex.Replace(input, "<.*?>", string.Empty);
    }
    //Delete the HTML space (&nbsp) from a string 
    public static string nbsp(string input)
    {
        return Regex.Replace(input, "&nbsp", string.Empty);
    }
    public void TaskOnClick(int i, JObject jsonObject)
    {

        /*int j = 0;

        
        
        for (int c=0; i-1>c;c++)
        { 

            if (string.Equals((string)jsonObject["data"][c]["translations"]["fr"]["content"][j]["type"], "gallery"))
            {
                print("numero de data "+c+" content numero "+ j+" has gallery" );
            }
            j++;

        }*/
    }



}
