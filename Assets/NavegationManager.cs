using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavegationManager : MonoBehaviour
{
    public NavMeshAgent player;
    public GameObject destination;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            SearchDestination();
        }
    }

    public void SearchDestination()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit))
        {
            //GameObject ds = Instantiate(destination, hit.point, Quaternion.identity);
            destination.transform.position = hit.point;
            player.SetDestination(destination.transform.position);
        }
    }


}
