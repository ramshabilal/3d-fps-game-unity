using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowAI : MonoBehaviour
{
    public enum States { Patrol, Follow, Attack };

    public NavMeshAgent agent;
    public Transform target;

    public Transform[] waypoints;

    [Header("AI Properties")]
    public float maxFollowDistance = 20f;
    public float shootDistance = 10f;
    public Weapon attackWeapon;

    private bool insight = false;
    private Vector3 directionToTarget;

    public States currentState;

    private int currentWaypoint = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        if (agent == null)
        {
            agent = GetComponent<NavMeshAgent>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        updateStates();
        CheckForPlayer();


        

    }

    private void updateStates() {
        switch (currentState ){
            case States.Patrol:
                Patrol();
                break;
            case States.Follow:
                Follow();
                break;
            case States.Attack:
                Attack();
                break;
        }
    }

    public void CheckForPlayer(){
        directionToTarget = target.position - transform.position;

        RaycastHit hitInfo; 

        if (Physics.Raycast(transform.position, directionToTarget.normalized, out hitInfo))
        {
            insight = hitInfo.transform.CompareTag("Player");
        }
    }

    private void Patrol() {
        // Implement patrol logic here
        if (agent.destination != waypoints[currentWaypoint].position)
        {
            agent.destination = waypoints[currentWaypoint].position;
        }
        if (HasReached())
        {
            currentWaypoint = (currentWaypoint + 1) % waypoints.Length;
        }
    }

    private void Follow() {
        if (agent.remainingDistance <= shootDistance && insight)
        {
            agent.ResetPath();
            currentState = States.Attack;
        } 
        else {
            if (target != null)
            {
                agent.SetDestination(target.position);
            }
        }
    }

    private void Attack() {
       if (!insight) {
        currentState = States.Follow;
       }
       attackWeapon.Fire();
    }

    private bool HasReached(){
        return (!agent.hasPath && !agent.pathPending && agent.remainingDistance <= agent.stoppingDistance); 
    }

 private void OnTriggerEnter(Collider other)
    {
        print("Here");
        // Check if the object colliding with the enemy has a specific tag
        if (other.CompareTag("Bullet"))
        {
            // If the colliding object is a bullet, destroy the enemy
            print("Not a bullet");
            Destroy(gameObject);
        }
        else {
            print("Not a bullet");
            Destroy(gameObject);        
            }
    }

}

   