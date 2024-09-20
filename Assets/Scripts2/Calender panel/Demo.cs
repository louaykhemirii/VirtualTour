using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

using SimpleJSON;
using TMPro;
using UnityEngine.Networking;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;


public static class ButtonExtension
{

	public static void AddEventListener<T>(this Button button, T param, Action<T> OnClick)
	{
		button.onClick.AddListener(delegate () {
			OnClick(param);
		});
	}
}

public class Demo : MonoBehaviour
{
	List<string> EventID = new List<string>();
	public Dropdown m_Dropdown;
	public Button EventButton;
	[Serializable]
	public struct Game
	{
		public string Name;
		public string Description;

	}

	
	string url = "https://www.orangedigitalcenters.com/api/v1/client/country/";
	string title, content, Startdate, EndDate, Day, Month, year, codingSchool, fabLabSolidaire, orangeFab, StartTime, EndTime, Url, EndMonth;

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
	public string check(int value)
	{
		Debug.Log("drop_down" + value);
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
			default:
				Country = "TN";
				break;
		}
		return Country;
	}
	void GetJson(WWW www)
	{
		GameObject buttonTemplate = transform.GetChild(1).gameObject;
		GameObject g;
		JObject jsonObject = JObject.Parse(www.text);
		int i = 0;
		foreach (object element in jsonObject["data"])
		{


			title = (string)jsonObject["data"][i]["translations"]["fr"]["title"];
			//content = (string)jsonObject["data"][i]["translations"]["fr"]["content"][0]["data"]["content"];
			Startdate = (string)jsonObject["data"][i]["startDate"];
			EndDate = (string)jsonObject["data"][i]["endDate"];

			Month = Startdate.Substring(0, 2);//substring the 2 characters defines the month from StartDate
			Day = Startdate.Substring(3, 2);//substring the 2 characters defines the Day from StartDate
			year = Startdate.Substring(6, 2);
			StartTime = Startdate.Substring(10, 6);
			EndTime = EndDate.Substring(10, 6);
			EndMonth = EndDate.Substring(8, 2) + " " + MonthAB(EndDate.Substring(0, 2));
			codingSchool = (string)jsonObject["data"][i]["creator"]["codingSchool"];
			fabLabSolidaire = (string)jsonObject["data"][i]["creator"]["fabLabSolidaire"];
			orangeFab = (string)jsonObject["data"][i]["creator"]["orangeFab"];
			EventID.Add((string)jsonObject["data"][i]["_id"]);

			g = Instantiate(buttonTemplate, transform);

			g.transform.GetChild(0).GetComponent<Text>().text = title;
			g.transform.GetChild(1).GetComponent<Text>().text = "From "+ Month+" "+ MonthAB(Month) + " at "+ StartTime+" To "+ EndMonth + " at "+ EndTime;
			g.transform.GetChild(2).GetComponent<Text>().text =	Month;
			g.transform.GetChild(3).GetComponent<Text>().text = MonthAB(Month);
			g.transform.GetChild(4).GetComponent<Text>().text = ByWho( codingSchool, fabLabSolidaire, orangeFab);
			
			/*g.GetComponent <Button> ().onClick.AddListener (delegate() {
				ItemClicked (i);
			});*/
			g.GetComponent<Button>().AddEventListener(i, ItemClicked);
			i++;
		}
		Destroy(buttonTemplate);



	}
	void ItemClicked(int itemIndex)
	{
		Debug.Log("------------item " + itemIndex + " clicked---------------");

		string EventUrl = "https://www.orangedigitalcenters.com/country/" + check(m_Dropdown.value) + "/events/" + EventID[itemIndex];
		Application.OpenURL(EventUrl);
		Debug.Log(EventUrl);
	}
	public string  MonthAB( string mois)
    {
		string M = "";
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
			if ((mois).CompareTo(month.Key) == 0)
			{
				M = month.Value;
			}
		}
		return M;
	}
	public string ByWho(string CodingSchool, string FabLab, string OrangeFab)
	{
		//Converting from String to Bool 
		bool CS = bool.Parse(CodingSchool);
		bool FB = bool.Parse(FabLab);
		bool OF = bool.Parse(OrangeFab);

		string bywho = "By ";



		if (CS)
		{
			bywho += "Coding School";


		}
		if (FB)
		{
			bywho += ",Fab Lab";


		}
		if (OF)
		{
			bywho += ",Orange Fab";


		}

		if ((!CS) && (!FB) && (!OF))
		{
			bywho = "";
		}

		return bywho;
	}
}