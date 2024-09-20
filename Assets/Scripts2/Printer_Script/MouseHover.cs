using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MouseHover : MonoBehaviour
{
    private bool clicked = false;
    public Texture2D cursorArrow;
    public GameObject cube;
    public GameObject Exit;
    public Texture2D cursorArrow2;
    public Description Desc;
    public GameObject OtherMachineDescription;
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
        cube.SetActive(true);
        Desc.visible();
        Exit.SetActive(true);
        OtherMachineDescription.SetActive(false);
        return clicked;
    }


}
