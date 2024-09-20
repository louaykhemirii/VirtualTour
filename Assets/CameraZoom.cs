using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraZoom : MonoBehaviour
{
    float minFov  = 15f;
    float maxFov= 90f;
    float sensitivity= 10f;
    public CinemachineVirtualCamera CMV;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float fov = CMV.m_Lens.FieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        CMV.m_Lens.FieldOfView = fov;
    }
    
} 
