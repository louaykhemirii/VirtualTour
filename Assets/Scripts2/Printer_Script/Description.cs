using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Description : MonoBehaviour
{
    public GameObject Desc;
    public GameObject descUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Open()
    {
        descUI.SetActive(true);
        descUI.GetComponent<Animator>().SetTrigger("OpenDesc");
        Desc.SetActive(false);
    }
    public void visible()
    {
        Desc.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
