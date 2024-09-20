using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject pub;
    public IntroAnimation animationCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
         
    }
    public void OnMouseDown()
    {

        pub.SetActive(true);
        animationCam.ReturnToOldCamera();

    }
}
