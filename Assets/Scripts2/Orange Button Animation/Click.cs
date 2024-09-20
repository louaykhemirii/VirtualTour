using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private bool clicked = false;
    public Texture2D cursorArrow;

    public Texture2D cursorArrow2;
    public GameObject desc;
    public GameObject ShowMore;
    public GameObject ExitButton;
    public GameObject OtherMachineDescription;
    public GameObject cube;
    public GameObject Desc;
    public void Update()
    {

        
    }
    public void OnMouseEnter()
    {
        //changer la curseur 

        Cursor.SetCursor(cursorArrow2, Vector2.zero, CursorMode.ForceSoftware);

    }
    public void OnMouseExit()
    {

        //récupérer l'ancienne curseur
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }
    public bool OnMouseDown()
    {
        clicked = true;
        desc.SetActive(true);
        ShowMore.SetActive(true);
        cube.SetActive(true);
        Desc.SetActive(true);
        ExitButton.SetActive(true);
        OtherMachineDescription.SetActive(false);

        return clicked;
    }
}
