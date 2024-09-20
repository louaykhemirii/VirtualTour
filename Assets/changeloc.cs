using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeloc : MonoBehaviour
{
    public Transform firstlocation;
    public Transform secondlocation;
    public Transform thirdlocation;
    //public GameObject g;
    Quaternion initrotation;
    //public GameObject player;
    public Transform OdcLoc;
    public Transform FabLoc;
    public Transform FabLabLoc;
    Quaternion x;
    public static string name;
    
    private void Start()
    {
        initrotation = Camera.main.transform.rotation;
    }
    public static int ii;
    
    void Update()
    {
        if(name=="ODC"){
           
           
        }
        
        if(name=="FabLab"){
          
            
        }
        if(name=="Fab"){
            
        }
        
        //name ="";
    }
    public void ChangeToODC()
    {
        /*foreach (Transform child in GameObject.FindGameObjectWithTag("Canvas").transform)
        {
            child.gameObject.SetActive(false);
        }
        while (Camera.main.transform.position != firstlocation.position)
        {
            Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, firstlocation.position, Time.deltaTime);
            //GameObject.FindGameObjectWithTag("Player").transform.position = GameObject.FindGameObjectWithTag("OdcLoc").transform.position;
        }
        Camera.main.orthographicSize = 12;
        Camera.main.transform.rotation = initrotation;
        aff.check = 0;
        //GameObject.FindGameObjectWithTag("Player").transform.position = GameObject.FindGameObjectWithTag("OdcLoc").transform.position;
*/
    }
    public void ChangeToFabLab()
    {
       /* foreach (Transform child in GameObject.FindGameObjectWithTag("Canvas").transform)
        {
            child.gameObject.SetActive(false);
        }

        while (Camera.main.transform.position != secondlocation.position)
        {
            Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, secondlocation.position, Time.deltaTime);
           
            //GameObject.FindGameObjectWithTag("Player").transform.position = GameObject.FindGameObjectWithTag("FabLoc").transform.position;

            
            
        }

        Camera.main.orthographicSize = 12;
        Camera.main.transform.rotation = initrotation;
        aff.check = 0;
        */
        //GameObject.FindGameObjectWithTag("Player").transform.position = GameObject.FindGameObjectWithTag("FabLoc").transform.position;
    }
    public void ChangeToFab()
    {
        /*foreach (Transform child in GameObject.FindGameObjectWithTag("Canvas").transform)
        {
            child.gameObject.SetActive(false);
        }

        while (Camera.main.transform.position != thirdlocation.position)
        {
            Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, thirdlocation.position, Time.deltaTime);

            //GameObject.FindGameObjectWithTag("Player").transform.position = GameObject.FindGameObjectWithTag("FabLoc").transform.position;



        }

        Camera.main.orthographicSize = 12;
        Camera.main.transform.rotation = initrotation;
        aff.check = 0;
        */
        //GameObject.FindGameObjectWithTag("Player").transform.position = GameObject.FindGameObjectWithTag("FabLoc").transform.position;
    }
    public  void Quit()
    {
        /*foreach (Transform child in GameObject.FindGameObjectWithTag("Canvas").transform)
        {
            child.gameObject.SetActive(false);
        }
        
        Camera.main.orthographicSize = 12;
        
        x.eulerAngles = new Vector3((float)21.8088741, (float)239.047516, (float)1.75863016);
        Camera.main.transform.rotation = x;
        aff.check = 0;*/
    }
}
