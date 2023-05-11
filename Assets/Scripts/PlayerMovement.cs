using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private UnityEngine.AI.NavMeshAgent agent;

    [SerializeField] private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(target.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
