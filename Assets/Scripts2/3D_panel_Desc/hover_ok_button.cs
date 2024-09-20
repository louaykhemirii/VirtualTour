using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class hover_ok_button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public IntroAnimation AnimationCam;
    public GameObject Cercle;
    public GameObject DescUI;
    public Texture2D cursorArrow;
    public GameObject canvas;
    public Texture2D cursorArrow2;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
       
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }
    public void OnPointerExit(PointerEventData eventData)
    {

        
        Cursor.SetCursor(cursorArrow2, Vector2.zero, CursorMode.ForceSoftware);
    }
    public void open()
    {
        //Desactivate Description pannel 
        Cercle.SetActive(true);
        DescUI.SetActive(false);
        
        //chnage cursor
        Cursor.SetCursor(cursorArrow2, Vector2.zero, CursorMode.ForceSoftware);
        
        
        AnimationCam.ReturnToOldCamera();
        
    }
    public void clique()
    {

        Cercle.SetActive(true);

    }
}
