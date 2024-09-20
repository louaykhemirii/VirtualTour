using UnityEngine;
using UnityEngine.UI;
using Shapes2D;
using System.Collections;

public class OnClickDescOpener : MonoBehaviour
{
    public GameObject descUI;
    public Shape objectTooltipMarker;
    public float blurLerpTime = 1f;
    public float outlineLerpTime = 1f;

    public float MaxBlur = 0.02f;
    public float MaxOutline = 0.03f;
    float startBlur;
    float startOutline;

    /// <summary>
    ///Couroutine
    /// </summary>
    float lerpTime = 1f;
    float currentLerpTime;
    float startBlurCo;
    float startOutlineCo;
    public float blurLerpTimeCo = 1f;
    public float outlineLerpTimeCo = 1f;
    public float MaxBlurCo = 0.05f;
    public float MaxOutlineCo = 0.08f;
    public bool isMouseOver = false;

    protected void Start()
    {
        startBlur = objectTooltipMarker.settings.blur;
        startOutline = objectTooltipMarker.settings.outlineSize;
        startBlurCo = objectTooltipMarker.settings.blur;
        startOutlineCo = objectTooltipMarker.settings.outlineSize;

    }

    protected void Update()
    {
        if (!isMouseOver)
        {
            float thetaBlur = Time.timeSinceLevelLoad / blurLerpTime;
            float thetaOutline = Time.timeSinceLevelLoad / blurLerpTime;
            float blurSize = Mathf.Abs(MaxBlur * Mathf.Sin(thetaBlur));
            float outlineSize = Mathf.Abs(MaxBlur * Mathf.Sin(thetaOutline));
            objectTooltipMarker.settings.blur = startBlur + blurSize;
            objectTooltipMarker.settings.outlineSize = startOutline + outlineSize;
        }

    }
    private void OnMouseDown()
    {
        if (descUI.activeInHierarchy)
        {
            descUI.SetActive(false);
        }
        else
        {
            descUI.SetActive(true);
            descUI.GetComponent<Animator>().SetTrigger("OpenDesc");
        }
        
    }
    void OnMouseOver()
    {
        StartCoroutine("OnMouseHover");
    }

    private IEnumerator OnMouseHover()
    {
        isMouseOver = true;
        //increment timer once per frame
        
        currentLerpTime += Time.deltaTime;
        if (currentLerpTime > lerpTime)
        {
            currentLerpTime = lerpTime;
        }

        //lerp!
        
            float perc = currentLerpTime / lerpTime;
        while (perc > 1)
        {
            startBlurCo = Mathf.Lerp(startBlurCo, MaxBlurCo, perc);
            startBlurCo = Mathf.Lerp(startOutlineCo, MaxOutlineCo, perc);
        }
        
        yield return null;
    }


    void OnMouseExit()
    {
        isMouseOver = false;
    }
}
