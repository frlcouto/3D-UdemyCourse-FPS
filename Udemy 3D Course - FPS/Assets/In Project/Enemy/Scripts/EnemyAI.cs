using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;

    NavMeshAgent enemyNavMeshAgent;

    void Awake()
    {
        enemyNavMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        
    }

    void Update()
    {   
        enemyNavMeshAgent.SetDestination(target.position);
    }
}
