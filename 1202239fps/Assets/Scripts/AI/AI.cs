using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;

    public Transform[] destinations;

    [Header("---FollowPlayer---?")]
    public bool followPlayer;
    private GameObject player;

    private float distanceToPlayer;

    public float distanceToFollow = 10;
    private int i = 0;
    public float distanceToFollowPath =2;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent.destination = destinations[0].transform.position;
        player=FindObjectOfType<PlayerMovement>().gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
    if(distanceToPlayer<=distanceToFollow  ){
        FollowPlayer();
    }       else{
        EnemyPath();
    }
    }

    public void EnemyPath(){
        navMeshAgent.destination = destinations[i].position;

        if(Vector3.Distance(transform.position,destinations[i].position) <= distanceToFollowPath){
            if(destinations[i] != destinations[destinations.Length - 1]){
                i++;
            }else{
                i=0;
            }
        }


    }

    public void FollowPlayer(){
        navMeshAgent.destination = player.transform.position;
    }
}
