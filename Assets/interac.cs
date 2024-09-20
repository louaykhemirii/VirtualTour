
using UnityEngine;
using UnityEngine.UI;
public class interac : MonoBehaviour
{
    public float radius = 3f;
    bool isFocus = false;
    Transform player;
    public static bool affchatbot;
    bool hasInteracted = false;
    

    private void Update()
    {
        

        if (isFocus && !hasInteracted)
        {
            
                float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= radius)
            {
                Debug.Log("interact!!!");
                hasInteracted = true;
                affchatbot = true;

                foreach (Transform child in GameObject.FindGameObjectWithTag("Canvas").transform)
                {
                    if(child.gameObject.GetComponent<DialogueViewer>().discnumber == transform.gameObject.GetComponent<aff>().x2)
                    {
                        child.gameObject.SetActive(true);
                    }
                    
                }
            }
        }
    }
    private void LateUpdate()
    {
        if (isFocus && !hasInteracted)
        {
            foreach (Transform child in GameObject.FindGameObjectWithTag("Canvas").transform)
            {
                if (child.gameObject.GetComponent<DialogueViewer>().discnumber == transform.gameObject.GetComponent<aff>().x2)
                {
                    child.gameObject.SetActive(false);
                }

            }
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= radius)
            {
                Debug.Log("interact!!!");
                hasInteracted = true;
                affchatbot = true;

                
            }
        }
    }


    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasInteracted = false;
        affchatbot = false;
    }
    public void OnDefocused()
    {
        isFocus = false;
        player = null;
        hasInteracted = false;
        affchatbot = false;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,radius);
    }
}
