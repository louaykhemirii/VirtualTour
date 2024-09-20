using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMov : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;
    Animator anum;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anum = GetComponentInChildren<Animator>();
    }
    private void Update()
    {
        if (target != null)
        {
            //calculer un nouveau chemin à chaque position 
            agent.SetDestination(target.position);
            FaceTarget();
            
        }
        //l'arret de mouvement lors de l'interaction avec le chatbot 
        if(interac.affchatbot == true)
        {
            anum.SetBool("isMoving", false);
        }
       
    }

    public void Move(Vector3 point)
    {
        
        agent.SetDestination(point);
        anum.SetBool("isMoving", true);
       
    }

    public void FollowTarget(interac newTarget)
    {
        agent.stoppingDistance = newTarget.radius*.5f;
        agent.updateRotation = false;
        target = newTarget.transform;
        anum.SetBool("isMoving", true);
        
    }
    public void Stop()
    {
        agent.stoppingDistance = 0;
        agent.updateRotation = true;
        target = null;
        anum.SetBool("isMoving", false);
    }

    void FaceTarget()
    {
        //la rotation du cube ou du joueur  vers le chemin calculer
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x,0f,direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation,lookRotation,Time.deltaTime * 5f);
    }
}
