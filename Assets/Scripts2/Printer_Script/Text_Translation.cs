using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Text_Translation : MonoBehaviour
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
                Item_name.GetComponent<Text>().text = "3D Printer";
                Description.GetComponent<Text>().text = "3D printing, also known as additive manufacturing, is a method of creating a three \ndimensional object layer-by-layer ";
            }
            else
            {
                Item_name.GetComponent<Text>().text = "Imprimente 3D";
                Description.GetComponent<Text>().text = "L'impression 3D, également connue sous le nom de fabrication additive,\nest une méthode de création d'un \nobjet en trois dimensions";
            }
        }
    }
}
