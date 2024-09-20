using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Continue_Button : MonoBehaviour
{
    public GameObject First_UI;
    public Dropdown m_Dropdown;
    public GameObject Image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

    public void open ()
    {
        
        if (m_Dropdown.value != 0)
        {
           
            First_UI.SetActive(false);
            Image.SetActive(false);
        }
       
    }
}
