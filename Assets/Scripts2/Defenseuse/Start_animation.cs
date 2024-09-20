using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_animation : MonoBehaviour
{
    public GameObject miller;
    public GameObject MaterialMov;
    public IntroAnimation CM6;
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
        MaterialMov.GetComponent<Animator>().Play("AscenseurAnimation");
        yield return new WaitForSeconds(2f);
        miller.GetComponent<Animator>().Play("defenseuseAnimation");
        yield return new WaitForSeconds(4f);
        miller.GetComponent<Animator>().Play("New State");
    }
    public void Click()
    {
        StartCoroutine(Move());
        CM6.SetCameraforMillingAnimation();

    }
}
