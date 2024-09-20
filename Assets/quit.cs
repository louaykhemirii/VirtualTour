using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    public GameObject g;
    Vector3 initpos;
    Quaternion initrotation;
    public void Quit()
    {
        foreach (Transform child in GameObject.FindGameObjectWithTag("Canvas").transform)
        {

            Destroy(child.gameObject);


        }
        Camera.main.transform.rotation = initrotation ;
        //Camera.main.transform.position = initpos;
        Camera.main.orthographicSize = 12;

        aff.check = 0;
    }
    private void Start()
    {
        initpos = Camera.main.transform.position;
       initrotation = Camera.main.transform.rotation;
    }
}
