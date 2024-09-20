using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class IntroAnimation : MonoBehaviour
{
    //Declaration de la classe mouseHover de l'imprimente 3D
   
    public Animation introAnimation;
    public CinemachineVirtualCamera CM1;
    public CinemachineVirtualCamera CM2;
    public CinemachineVirtualCamera CM3;
    public CinemachineVirtualCamera CM4;
    public CinemachineVirtualCamera CM5;
    public CinemachineVirtualCamera CM6;
    public CinemachineVirtualCamera CM7;
    public CinemachineVirtualCamera CM8;
    public CinemachineVirtualCamera CM9;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayIntroAnimation()
    {
        introAnimation.Play();
    }
    public void SetNewMAinCamAfterIntroAnimation()
    {
        CM2.Priority = 1;
        CM1.Priority = 15;
        
    }
    public void SetCameraForPrinter()
    {
        CM3.Priority = 15;
        CM1.Priority = 0;
        CM4.Priority = 0;
        CM5.Priority = 0;
        CM6.Priority = 0;
        CM7.Priority = 0;
        CM8.Priority = 0;
        CM9.Priority = 0;

    }
    public void ReturnToOldCamera()
    {
        CM3.Priority = 0;
        CM4.Priority = 0;
        CM5.Priority = 0;
        CM1.Priority = 15;
        CM6.Priority = 0;
        CM7.Priority = 0;
        CM8.Priority = 0;
        CM9.Priority = 0;
    }
    public void SetCameraForTableMachine()
    {
        CM3.Priority = 0;
        CM5.Priority = 0;
        CM1.Priority = 0;
        CM4.Priority = 15;
        CM6.Priority = 0;
        CM7.Priority = 0;
        CM8.Priority = 0;
        CM9.Priority = 0;

    }
    public void SetCameraForDragging()
    {
        CM5.Priority = 15;
        CM3.Priority = 0;
        CM1.Priority = 0;
        CM4.Priority = 0;
        CM6.Priority = 0;
        CM7.Priority = 0;
        CM8.Priority = 0;
        CM9.Priority = 0;

    }
    public void SetCameraForMillingMachine()
    {

        CM5.Priority = 0;
        CM8.Priority = 0;
        CM3.Priority = 0;
        CM1.Priority = 0;
        CM4.Priority = 0;
        CM6.Priority = 0;
        CM7.Priority = 15;
        CM9.Priority = 0;
    }
    public void SetCameraforMillingAnimation()
    {
        CM5.Priority = 0;
        CM3.Priority = 0;
        CM1.Priority = 0;
        CM4.Priority = 0;
        CM6.Priority = 15;
        CM7.Priority = 0;
        CM8.Priority = 0;
        CM9.Priority = 0;
    }
    public void SetCameraForLogin()
    {
        
            CM2.Priority = 15;
        CM3.Priority = 0;
        CM1.Priority = 0;
        CM4.Priority = 0;
        CM5.Priority = 0;
        CM6.Priority = 0;
        CM7.Priority = 0;
        CM8.Priority = 0;
        CM9.Priority = 0;

    }
    public void SetCameraForPub()
    {
        CM8.Priority = 15;
        CM2.Priority = 0;
        CM3.Priority = 0;
        CM1.Priority = 0;
        CM4.Priority = 0;
        CM5.Priority = 0;
        CM6.Priority = 0;
        CM7.Priority = 0;
        CM9.Priority = 0;
        


    }
    public void SetCameraFPS()
    {
        CM8.Priority = 0;
        CM2.Priority = 0;
        CM3.Priority = 0;
        CM1.Priority = 0;
        CM4.Priority = 0;
        CM5.Priority = 0;
        CM6.Priority = 0;
        CM7.Priority = 0;
        CM9.Priority = 15;
    }
}
