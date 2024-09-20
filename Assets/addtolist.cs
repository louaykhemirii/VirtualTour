using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor.UI;

public class addtolist : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text t1;
    [SerializeField] UnityEngine.UI.Text t2;
    [SerializeField] GameObject g1;
    [SerializeField] GameObject g2;
    



    public void afflist()
    {
        DialogueViewer.affdialo();
    }
    List<diars> di = DialogueViewer.rdiars();


}
