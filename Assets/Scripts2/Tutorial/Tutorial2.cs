using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial2 : MonoBehaviour
{
    public GameObject Calendrier;
    public Tutorial1 Tutorial_1;
    public GameObject Tutorial_2;
    public Texture2D cursorArrow2;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void Open()
    {
        Tutorial_2.SetActive(true);


    }
    public void Destroy1()
    {
        Cursor.SetCursor(cursorArrow2, Vector2.zero, CursorMode.ForceSoftware);
        Destroy(Tutorial_2);
        Calendrier.SetActive(true);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
