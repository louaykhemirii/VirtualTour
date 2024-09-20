
using UnityEngine;

public class Example : MonoBehaviour
{
    
    float width;
    float height;
    public GameObject myball;
    RectTransform rt;
    public float GetWidth()
    {
        rt = (RectTransform)myball.transform;

        width = rt.rect.width;
       
       
        
        return width;
    }
    public float GetHeight()
    {
        rt = (RectTransform)myball.transform;

        
        height = rt.rect.height;
        
        return height;
    }

} 