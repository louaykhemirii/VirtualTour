using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calendrier : MonoBehaviour
{
    public GameObject SecondButton;
    public GameObject ThisButton;
    public GameObject CalendrierOBJ;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        CalendrierOBJ.gameObject.GetComponent<Animator>().enabled = false;
    }
  public void animUp()
    {
        CalendrierOBJ.gameObject.GetComponent<Animator>().enabled = true;
        
        CalendrierOBJ.GetComponent<Animator>().Play("New Animation");
        SecondButton.SetActive(true);
        ThisButton.SetActive(false);
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
