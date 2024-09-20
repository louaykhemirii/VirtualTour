using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class onmouseover : MonoBehaviour
{
    [SerializeField] private TextWriter textWriter;
    private Text messageText;
    public animate_Canvas anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator OnMouseEnter()
    {

        anim.Open();
        yield return new WaitForSeconds(10);
        anim.Close();
    }
    public void OnMouseExit()
    {
        anim.Close();

    }
}
