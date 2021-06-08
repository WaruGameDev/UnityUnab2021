using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class GuardianEnemy : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform destino;
    public Transform player;
    public Transform eyes;
    public SphereCollider zonaDeVision;
    public float angleOfVision = 60;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            player = other.transform;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = null;
        }
    }
    private void Update()
    {
        
        if (player!= null)
        {
            if(PlayerIsInSight() && InFrontOfPlayer())
            {
                enemy.SetDestination(player.position);
            }
        }
        else
        {
            // colocar que vuelva a patrullar.
        }
    }

    bool PlayerIsInSight()
    {
        //lanzar raycast al player
        Vector3 difference = (player.position - eyes.position).normalized;
        Debug.DrawRay(eyes.position, difference * zonaDeVision.radius);
        RaycastHit hit;
        bool observandoPlayer = false;
        if (Physics.Raycast(eyes.position, difference, out hit, zonaDeVision.radius))
        {
            if(hit.transform.CompareTag("Player"))
            {
                observandoPlayer = true;
            }
        }
        return observandoPlayer;
    }
    bool InFrontOfPlayer()
    {
        bool playerIsfront = false;
        Vector3 difference = player.position - eyes.position;
        float anguloDistancia = Vector3.Angle(eyes.forward, difference);

        if (anguloDistancia < angleOfVision)
        {
            playerIsfront = true;
        }
        return playerIsfront;
    }
    

}
