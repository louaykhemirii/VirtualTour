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
                Description.GetComponent<Text>().text = "Technologies d'impression 3D Il existe trois grands types de technologie d'impression 3D ; frittage, fusion et st�r�olithographie. Le frittage est une technologie o� le mat�riau est chauff�, mais pas au point de fondre, pour cr�er des articles � haute r�solution. La poudre m�tallique est utilis�e pour le frittage laser direct de m�tal tandis que les poudres thermoplastiques sont utilis�es pour le frittage laser s�lectif. Les m�thodes de fusion de l'impression 3D comprennent la fusion sur lit de poudre, la fusion par faisceau d'�lectrons et le d�p�t d'�nergie directe. Celles-ci utilisent des lasers, des arcs �lectriques ou des faisceaux d'�lectrons pour imprimer des objets en faisant fondre les mat�riaux ensemble � des temp�ratures �lev�es. La st�r�olithographie utilise la photopolym�risation pour cr�er des pi�ces. Cette technologie utilise la bonne source de lumi�re pour interagir avec le mat�riau de mani�re s�lective afin de durcir et de solidifier une section transversale de l'objet en couches minces.";
            }
        }
    }
}
