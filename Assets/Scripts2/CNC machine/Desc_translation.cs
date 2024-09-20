using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Desc_translation : MonoBehaviour
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
                Item_name.GetComponent<Text>().text = "CNC machine";
                
                Description.GetComponent<Text>().text = "A computer-controlled cutting machine which typically mounts a\nhand-held router as a spindle";
            }
            else
            {
                Item_name.GetComponent<Text>().text = "CNC machine";
                Description.GetComponent<Text>().text = "Est une machine équipée de plusieurs outils et d'une commande\nnumérique pilotée par un ordinateur ";
            }
        }
    }
}
