using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMov))]
public class PlayerController : MonoBehaviour
{

    public Camera cam ;
    PlayerMov mov;
    public LayerMask floor;

    public interac focus;
    public static bool stopmov = false;
    private GetPlayerInformations player;
    
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        mov = GetComponent<PlayerMov>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //si il y'a pas  une interaction avec le chatbot
        if (aff.check == 0)
        {
            
                RemoveFocus();
            
        }
        //indiquer la position de focus de la curseur 
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            

            if(Physics.Raycast(ray,out hit, 500))
            {
                Debug.Log(hit.point);
                mov.Move(hit.point);
                interac interac = hit.collider.GetComponent<interac>();
                if(interac != null)
                {
                    SetFocus(interac);
                    

                }

            }
        }
    }
    //le joueur sui la position de la curseur 
    void SetFocus(interac newFocus)
    {
        if(newFocus != focus)
        {
            if(focus != null)
                focus.OnDefocused();

            focus = newFocus;
            mov.FollowTarget(newFocus);
        }

        stopmov = true;

        newFocus.OnFocused(transform);
      
       
    }
    //faire stopper le joueur
    void RemoveFocus()
    {
        if(focus!=null)
            focus.OnDefocused();

        focus = null;
        mov.Stop();
        stopmov = false;
    }
    
}
