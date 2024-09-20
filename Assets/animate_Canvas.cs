using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class animate_Canvas : MonoBehaviour
{
    
    [SerializeField] private TextWriter textWriter;
    private Text messageText;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector2.zero;
    }
    private void Awake()
    {
        messageText = transform.Find("messageText").GetComponent<Text>();

    }
    public void Open()
    {
        transform.LeanScale(Vector2.one, 0.8f);

        textWriter.AddWriter(messageText, "3D printing, or additive manufacturing, is the construction of a three-dimensional object from a CAD model or a digital 3D model.[1] The term '3D printing' can refer to a variety of processes in which material is deposited, joined or solidified under computer control to create a three-dimensional object,[2] with material being added together (such as plastics, liquids or powder grains being fused together), typically layer by layer.", 0.03f);

    }
   public  void Close()
    {
        

        transform.LeanScale(Vector2.zero, 0.8f);
    }
    
}

