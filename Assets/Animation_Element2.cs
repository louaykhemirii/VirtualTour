using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Element2 : MonoBehaviour
{
    public GameObject printer;
    public GameObject Orange;
    public GameObject Orange2;
    public GameObject ElementToDelete;
    public bool isMoving = false;

    public GameObject Car;
    public bool test = false;
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
        isMoving = true;
        Orange.GetComponent<Animator>().Play("New Animation");
        printer.GetComponent<Animator>().Play("New Animation");
        yield return new WaitForSeconds(10f);
        Orange2.SetActive(true);
        printer.GetComponent<Animator>().Play("New State");
        Orange.GetComponent<Animator>().Play("New State");

        isMoving = false;
    }

    public void click()
    {
        Car.GetComponent<Animator>().Play("New State");
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
