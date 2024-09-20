using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimDownButton : MonoBehaviour
{
    
    
    public GameObject ThisButton;
    public GameObject FirstButton;
    public GameObject CalendrierOBJ;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void AnimDown()
    {
        CalendrierOBJ.GetComponent<Animator>().Play("MoveDownAnimation");
        ThisButton.SetActive(false);
        FirstButton.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
