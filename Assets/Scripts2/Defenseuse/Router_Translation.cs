using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Router_Translation : MonoBehaviour
{
    public Dropdown m_Dropdown;
    public Text Item_name;
    public Text Description;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        check(m_Dropdown.value);
    }

    public void check(int value)
    {
        if (value != 0)
        {
            if ((value == 5) || (value == 14) || (value == 4))
            {
                Item_name.GetComponent<Text>().text = "CNC Router";

                Description.GetComponent<Text>().text = "A CNC Router is a computer-controlled cutting machine which typically mounts a hand-held router as a spindle which is used for cutting various \nmaterials, such as wood, composites";
            }
            else
            {
                Item_name.GetComponent<Text>().text = "Défenseuse numérique ";
                Description.GetComponent<Text>().text = "Un routeur CNC est une machine de découpage contrôlée par ordinateur qui monte généralement un routeur portatif en tant que broche\nutilisée pour couper divers matériaux tels\nque le bois ";
            }
        }
    }
}
