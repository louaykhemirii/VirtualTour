using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WelcomeScreen : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Texture2D cursorArrow;
    public GameObject Welcome;
    public Texture2D cursorArrow2;

    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.GetComponentInChildren<Text>().color = Color.white;
        //Debug.Log(gameObject.GetComponentInChildren<Text>().text);
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        
        gameObject.GetComponentInChildren<Text>().color = Color.black;
        Cursor.SetCursor(cursorArrow2, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void closewelcomescreen(){
        Cursor.SetCursor(cursorArrow2, Vector2.zero, CursorMode.ForceSoftware);
        Welcome.SetActive(false);
    }

}
