using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFPSObject : MonoBehaviour
{
    public GameObject bullet;
    public Transform canon;
    public float potencia = 800;
    
    public void Shoot()
    {
        GameObject bulletGo = Instantiate(bullet, canon.position, Quaternion.identity);
        bulletGo.GetComponent<Rigidbody>().AddForce(potencia * canon.transform.forward);
    }
    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
}
