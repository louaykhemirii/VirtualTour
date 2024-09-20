using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_animation : MonoBehaviour
{
    public GameObject light;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        light.GetComponent<Animator>().Play("New Animation");

    }

}