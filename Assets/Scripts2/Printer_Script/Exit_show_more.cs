using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_show_more : MonoBehaviour
{
    public GameObject Exit;
    public show_more sh;
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
        Exit.SetActive(false);
        sh.OnMouseExit();
    }
}

