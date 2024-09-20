using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class show_canvas : MonoBehaviour
{
    [Header("Tweaks")]
    [SerializeField] public Transform lookAt;
    [SerializeField] public Vector3 offset;
    [Header("Logic")]
    public  Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = cam.WorldToScreenPoint(lookAt.position + offset);
        if (transform.position != pos)
            transform.position = pos;
    }
}
