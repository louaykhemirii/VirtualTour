using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pub : MonoBehaviour
{
    public GameObject cube;
    //public GameObject Exit;
    public GameObject Apply;
    public Texture2D cursorArrow;
    public IntroAnimation animationCam;
    public Texture2D cursorArrow2;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        Apply.SetActive(true);
        //Desactivate the cube collider (Button)
        cube.SetActive(false);
        //Desactivate the cube collider (Exit)
        //Exit.SetActive(false);
        //change Cursor
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
        //change Camera (zoom to the object)
        animationCam.SetCameraForPub();
        
    }
    public void OnMouseEnter()
    {
        //Change Cursor

        Cursor.SetCursor(cursorArrow2, Vector2.zero, CursorMode.ForceSoftware);

    }
    public void OnMouseExit()
    {

        //Change Cursor
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }
}
