using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Animation : MonoBehaviour
{
    public GameObject printer;
    public GameObject Car;
    public GameObject Car2;
    public bool isMoving = false;
    public bool test = false;
    public GameObject ElementToDelete;
    public GameObject Orange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Move()
    {
        Orange.GetComponent<Animator>().Play("New State");
        isMoving = true;
        Car.GetComponent<Animator>().Play("Created Object");
        printer.GetComponent<Animator>().Play("New Animation");
        yield return new WaitForSeconds(10f);
        Car2.SetActive(true);
        printer.GetComponent<Animator>().Play("New State");
        Car.GetComponent<Animator>().Play("New State");

        isMoving = false;
    }

    public void click()
    {
        ElementToDelete.SetActive(false);
        test = true;
        if (test)
        {
            if (isMoving == false)
            {
                StartCoroutine(Move());
            }
        }
        printer.GetComponent<Animator>().Play("Pen");
        
    }
}
