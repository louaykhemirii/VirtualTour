using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialToMill : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {


        if (other.tag == "pixel")
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
