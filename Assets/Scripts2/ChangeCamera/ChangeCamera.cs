using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
  public   IntroAnimation cam;
   public  GameObject CameraButton1;
    public GameObject CameraButton2;
    public Texture2D cursorArrow;
    public Texture2D cursorArrow2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void clique()
    {
        cam.SetCameraFPS();
        CameraButton1.SetActive(false);
        CameraButton2.SetActive(true);
        
    }
    public void clique2()
    {
        cam.ReturnToOldCamera();
        CameraButton1.SetActive(true);
        CameraButton2.SetActive(false);
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
