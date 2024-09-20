using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCNCMachine : MonoBehaviour
{
    public GameObject Exit;
    public more sh;
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
