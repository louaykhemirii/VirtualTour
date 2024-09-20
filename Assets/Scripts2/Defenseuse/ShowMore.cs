using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMore : MonoBehaviour
{
    public GameObject cube;
    //public GameObject Exit;
    public GameObject Desc;
    public GameObject descUI;
    public Texture2D cursorArrow;
    public IntroAnimation animationCam;
    public Texture2D cursorArrow2;
    public GameObject Cercle;
    //public GameObject trytoprint;
    // Start is called before the first frame update
    void Start() 
    {

    }
    public void OnMouseDown()
    {
        //show the description panel 
        descUI.SetActive(true);
        descUI.GetComponent<Animator>().SetTrigger("OpenDesc");
        //Desactivate the first Canvas
        Desc.SetActive(false);
        //Desactivate the cube collider (Button)
        cube.SetActive(false);
        //Desactivate the cube collider (Exit)
        //Exit.SetActive(false);
        //change Cursor
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
        //change Camera (zoom to the object)
        animationCam.SetCameraForMillingMachine();
        //Desactivate the orange cercle 
        Cercle.SetActive(false);
        //trytoprint.SetActive(false);
    }
    public void visible()
    {
        Desc.SetActive(true);
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
    // Update is called once per frame
    void Update()
    {

    }
}
