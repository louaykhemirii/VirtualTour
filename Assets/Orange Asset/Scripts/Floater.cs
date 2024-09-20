// Floater v0.0.2
// by Donovan Keith
//
// [MIT License](https://opensource.org/licenses/MIT)

using UnityEngine;
using System.Collections;

// Makes objects float up & down while gently spinning.
public class Floater : MonoBehaviour
{
    // User Inputs
    public float degreesPerSecond = 15.0f;
    public float amplitude = 0.5f;
    public float frequency = 1f;
   
    public float shadowamplitude = 2f;
    public float shadowfrequency = 1f;
    public GameObject shadowSatic;

    // Position Storage Variables
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    Vector3 shadowPosition = new Vector3();

    // Use this for initialization
    void Start()
    {
        // Store the starting position & rotation of the object
        posOffset = transform.position;
        if(shadowSatic == null)
        {

        }
        else
        {
            shadowPosition = shadowSatic.transform.position;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (shadowSatic == null)
        {

        }
        else
        {
            shadowSatic.transform.position = shadowPosition;
            shadowSatic.transform.localScale = new Vector3(1+Mathf.Cos(Time.fixedTime * Mathf.PI * shadowfrequency) * shadowamplitude, 1+Mathf.Cos(Time.fixedTime * Mathf.PI * shadowfrequency) * shadowamplitude, 1);
        }
        // Spin object around Y-Axis
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);

        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }
}