using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleCharacterCreater : MonoBehaviour
{
    public Camera camera ;
    public Canvas  canvas;
    public GameObject player;
    public GameObject customplayer; 
    public void toggleCC()
    {
        if (!camera.gameObject.active)
        {
            camera.gameObject.SetActive(true);
            canvas.gameObject.SetActive(true);
        }
        else
        {
            camera.gameObject.SetActive(false);
            canvas.gameObject.SetActive(false);
        }
        
    }
    public void submit()
    {
        camera.gameObject.SetActive(false);
        canvas.gameObject.SetActive(false);
        player = customplayer;
    }
}
