using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LanguagesSelector : MonoBehaviour
{
    public TextMeshProUGUI introText;
    public Text moButton;
    public Text tnButton;
    public Color orangeColor = new Color(255,121,0,255);
    public void SelectLanguage(string Lng)
    {
        if(Lng == "TN")
        {
            moButton.color = Color.white;
            tnButton.color = orangeColor;
            introText.text = "24000 young Tunisians have already been trained and supported in digital and 1800 have benefited from professional conversion courses. What's more, 800 middle and high school students have been introduced to coding, and 95% of them have already found jobs in Tunisia and abroad.";
        }
        if (Lng == "MO")
        {
            moButton.color = orangeColor;
            tnButton.color = Color.white;
            introText.text = "The 1st innovation center in Morocco has launched five flagship programs since its opening in July 2021. More than 150 young Moroccans have been trained and coached, 27 of whom have launched their projects. Other training programs are underway combining digital development, design, and personal development.";
        }
    }
}
