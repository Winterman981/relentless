using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkingAlly : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent agent;

    Vector2 Direction;
    public GameObject findTarget;

    bool isFighting = false;



    // Start is called before the first frame update
    void Start()
    {
        findTarget = GameObject.Find("AllyTarget");
        target = findTarget.transform;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 targetPos = target.position;

        Direction = targetPos - (Vector2)transform.position;

        if (isFighting == false)
        {
            transform.up = Direction;
            agent.SetDestination(target.position);
        }
    }

    public void Advance()
    {
        if (isFighting == true)
        {
            gameObject.GetComponent<NavMeshAgent>().isStopped = false;
            isFighting = false;
        }
    }

    public void Stop()
    {
        if (isFighting == false)
        {
            gameObject.GetComponent<NavMeshAgent>().isStopped = true;
            isFighting = true;
        }
    }
}
