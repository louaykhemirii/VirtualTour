using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monthSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       var x= GameObject.FindGameObjectWithTag("Tag 4").transform.position;
        print("tag 4" + x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
