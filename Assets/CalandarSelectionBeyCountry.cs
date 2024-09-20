using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalandarSelectionBeyCountry : MonoBehaviour
{
    public string Country;
    public GameObject Calandar1;
    public GameObject Calandar2;
    public GameObject Calandar3;

    public void CalandarSelection(string CountryCode)
    {
        /*if(CountryCode == "TN")
        {
            Calandar1.SetActive(true);
        }
        if (CountryCode == "MA")
        {
            Calandar2.SetActive(true);
        }
        if (CountryCode == "CI")
        {
            Calandar3.SetActive(true);
        }*/
        switch (CountryCode)
        {
            case "TN":
                print("Error NO FUTUR EVENT");
                break;
            case "MA":
                Calandar2.SetActive(true);
                break;
            case "CI":
                print("Error NO FUTUR EVENT");
                break;
            case "EG":
                Calandar1.SetActive(true);
                break;
            case "TT":
                print("Error");
                break;
            default:
                print("Error Incorrect Sign parsing JSON");
                Debug.LogError("Error Incorrect Sign parsing JSON");
                break;
        }
    }
}
