using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apply : MonoBehaviour
{
    public Texture2D cursorArrow;
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
        
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
        Application.OpenURL("https://www.orangedigitalcenters.com/country/jo/events/62aaf75c691a42003b1501a3");

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
