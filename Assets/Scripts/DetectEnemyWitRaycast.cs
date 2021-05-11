using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class DetectEnemyWitRaycast : MonoBehaviour
{
    public Transform eyes;
    public float length = 5;
    public Transform enemy;
    public NavMeshAgent agent;

    private void Update()
    {
        RaycastHit hit;
        Vector3 directionToEnemy = (enemy.position - eyes.position).normalized;
        
        if(Physics.Raycast(eyes.position, directionToEnemy, out hit, length))
        {
            if(hit.collider.CompareTag("Enemy"))
            {
                agent.SetDestination(enemy.position);
            }
            
        }
    }




}
