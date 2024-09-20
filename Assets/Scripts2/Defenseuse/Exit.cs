using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject ExitButton;
    public ShowMore sh;
    public GameObject cube;
    public GameObject Desc;
    public void OnMouseEnter()
    {
        sh.OnMouseEnter();

    }
    public void OnMouseExit()
    {
        sh.OnMouseExit();
    }
    public void OnMouseDown()
    {
        Desc.SetActive(false);
        cube.SetActive(false);
        ExitButton.SetActive(false);
        sh.OnMouseExit();
    }
}

