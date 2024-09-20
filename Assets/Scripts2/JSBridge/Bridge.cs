using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class Bridge : MonoBehaviour
{

#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void ShowMessage();
#endif

    
    

    // Start is called before the first frame update
    void Start()
    {
        #if !UNITY_EDITOR && UNITY_WEBGL
        WebGLInput.captureAllKeyboardInput = false;
        #endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SendToJS() {
        
       
#if UNITY_WEBGL && !UNITY_EDITOR
        ShowMessage();
#endif
    }

    

}
