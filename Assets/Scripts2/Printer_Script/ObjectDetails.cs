using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetails : MonoBehaviour
{
    public GameObject printer;
    public IntroAnimation intro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void  open ()
    {
        intro.SetCameraForDragging();
        printer.SetActive(true);
    }
}
