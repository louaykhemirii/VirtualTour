using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class look : MonoBehaviour
{

    public static Vector3 target;
    public static Transform t ;
    public float speed = 6;
    public CinemachineVirtualCamera vcam ;
   
    // Update is called once per frame
    void Update()
    {

        if (aff.check != 0 && interac.affchatbot == true)
        {
            
            
            transform.LookAt(target);
            if (vcam.m_Lens.OrthographicSize >= 5)
            {
                
                vcam.m_Lens.OrthographicSize--;
                Debug.Log("Camera Size : "+vcam.m_Lens.OrthographicSize);
            }
        }
        if(CloseChatBot.cl == true){
            Quit();
            CloseChatBot.cl = false;
        }

        
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, t.rotation, speed * Time.deltaTime);
    }
    public  void Quit()
    {
        foreach (Transform child in GameObject.FindGameObjectWithTag("Canvas").transform)
        {
            child.gameObject.SetActive(false);
        }
        
        vcam.m_Lens.OrthographicSize = 13;
        
       
        aff.check = 0;
    }
    
}
