using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnRaycast : MonoBehaviour
{
    public int damage;
    public float rayLenght = 100;

    private void Update()
    {
        Ray deteccionEnemigo = new Ray(transform.position, transform.forward);
        RaycastHit raycastHit;
       
        Debug.DrawRay(transform.position, transform.forward * rayLenght);
        if(Physics.Raycast(deteccionEnemigo, out raycastHit, rayLenght))
        {            
            if (Input.GetButtonDown("Jump"))
            {
                raycastHit.transform.GetComponent<HP_Character>().TakeDamage(damage);
            }
        }
       

    }
}
