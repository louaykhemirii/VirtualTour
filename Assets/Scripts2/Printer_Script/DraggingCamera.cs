using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggingCamera : MonoBehaviour
{
    float rotationSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void OnMouseDrag()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
        transform.Rotate(Vector3.down, XaxisRotation);
        transform.Rotate(Vector3.right, YaxisRotation);
    }
}
