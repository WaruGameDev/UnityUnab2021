using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnRayCast : MonoBehaviour
{
    public Material materialACambiar;
    public Transform raycastObject;
    public Material originalMaterial;
   

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 100);
        RaycastHit[] raycastHit;
        raycastHit = Physics.RaycastAll(transform.position, transform.up);
        foreach(RaycastHit r in raycastHit)
        {
            r.transform.GetComponent<Renderer>().material = materialACambiar;
        }
       
        //if(Physics.Raycast(transform.position, transform.forward, out raycastHit))
        //{
        //    raycastObject = raycastHit.transform;            
        //    raycastObject.GetComponent<Renderer>().material = materialACambiar;
        //    //            raycastHit.transform.GetComponent<Renderer>().material = materialACambiar;
        //}
        //else
        //{
        //    if(raycastObject != null)
        //    {
        //        raycastObject.GetComponent<Renderer>().material = originalMaterial;
        //    }
        //}
    }
}
