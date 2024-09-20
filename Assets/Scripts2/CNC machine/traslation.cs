using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class traslation : MonoBehaviour
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
                Item_name.GetComponent<Text>().text = "CNC Table machine";
                Description.GetComponent<Text>().text = "CNC – Computer Numerical Control – Taking digitized data, a computer and CAM program is used to control, automate, and monitor the movements of a machine. The machine can be a milling machine, lathe, router, welder, grinder, laser or waterjet cutter, sheet metal stamping machine, robot, or many other types of machines. For larger industrial machines, the computer is generally an on-board dedicated controller. But for more hobbyist types of machines, or with some retrofits, the computer can be an external PC. The CNC controller works together with a series of motors and drive components to move and control the machine axes, executing the programmed motions. On the industrial machines there is usually a sophisticated feedback system that constantly monitors and adjusts the cutter's speed and position.";
            }
            else
            {
                Item_name.GetComponent<Text>().text = "Machine CNC";
                Description.GetComponent<Text>().text = "La table de découpe numérique CNC  ou computer numerical control en anglais est une machine équipée de plusieurs outils et d’une commande numérique pilotée par un ordinateur. Le secteur de l’usinage industriel s’est vite doté de ce type de machine. Elles permettent incontestablement une optimisation du rendement, de la productivité et de la qualité des travaux effectués avec une intervention plus que minimale de l’homme. La table de découpe numérique est automatisée. Elle gère donc seule toute la chaine de production. Là où auparavant il fallait qu’une équipe entière d’hommes intervienne, un seul suffit maintenant.  ";
            }
        }
    }
}
