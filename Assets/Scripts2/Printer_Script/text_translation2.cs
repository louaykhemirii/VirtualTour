using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class text_translation2 : MonoBehaviour
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
                Description.GetComponent<Text>().text = "3D Printing Technologies There are three broad types of 3D printing technology; sintering, melting, and stereolithography. Sintering is a technology where the material is heated, but not to the point of melting, to create high resolution items. Metal powder is used for direct metal laser sintering while thermoplastic powders are used for selective laser sintering. Melting methods of 3D printing include powder bed fusion, electron beam melting and direct energy deposition, these use lasers, electric arcs or electron beams to print objects by melting the materials together at high temperatures. Stereolithography utilises photopolymerization to create parts. This technology uses the correct light source to interact with the material in a selective manner to cure and solidify a cross section of the object in thin layers.";
            }
            else
            {
                Item_name.GetComponent<Text>().text = "Imprimente 3D";
                Description.GetComponent<Text>().text = "Technologies d'impression 3D Il existe trois grands types de technologie d'impression 3D ; frittage, fusion et stéréolithographie. Le frittage est une technologie où le matériau est chauffé, mais pas au point de fondre, pour créer des articles à haute résolution. La poudre métallique est utilisée pour le frittage laser direct de métal tandis que les poudres thermoplastiques sont utilisées pour le frittage laser sélectif. Les méthodes de fusion de l'impression 3D comprennent la fusion sur lit de poudre, la fusion par faisceau d'électrons et le dépôt d'énergie directe. Celles-ci utilisent des lasers, des arcs électriques ou des faisceaux d'électrons pour imprimer des objets en faisant fondre les matériaux ensemble à des températures élevées. La stéréolithographie utilise la photopolymérisation pour créer des pièces. Cette technologie utilise la bonne source de lumière pour interagir avec le matériau de manière sélective afin de durcir et de solidifier une section transversale de l'objet en couches minces.";
            }
        }
    }
}
