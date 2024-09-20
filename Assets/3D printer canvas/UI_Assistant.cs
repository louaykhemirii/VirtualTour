using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Assistant : MonoBehaviour {
    [SerializeField] private TextWriter textWriter;
    private Text messageText;
     
    private void Awake()
{
        messageText = transform.Find("message").Find("messageText").GetComponent<Text>();

}
    private void Start()
    {
        textWriter.AddWriter(messageText, "3D printing, or additive manufacturing, is the construction of a three-dimensional object from a CAD model or a digital 3D model.[1] The term '3D printing' can refer to a variety of processes in which material is deposited, joined or solidified under computer control to create a three-dimensional object,[2] with material being added together (such as plastics, liquids or powder grains being fused together), typically layer by layer.", 0.05f);
    }

}
