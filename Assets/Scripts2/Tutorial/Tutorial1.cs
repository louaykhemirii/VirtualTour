using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial1 : MonoBehaviour
{
    public GameObject Calendrier;
    public GameObject Tutorial_1;
    public Tutorial2 Tutorial_2;
    public Texture2D cursorArrow2;

    // Start is called before the first frame update
    void Start()
    {
        Tutorial_1.transform.localScale = Vector2.zero;
    }
    public void  wait()
    {
        Invoke("Open", 3f);
    }
    // Update is called once per frame
    public void Open()
    {
        
        Cursor.SetCursor(cursorArrow2, Vector2.zero, CursorMode.ForceSoftware);
        Tutorial_1.transform.LeanScale(Vector2.one, 0.8f);
    }
    public void Destroy1()
    {
        Calendrier.SetActive(true);
        Destroy(Tutorial_1);
            
    }
    public void Next()
    {
        Tutorial_1.SetActive(false);
        Tutorial_2.Open();
        
    }
}
