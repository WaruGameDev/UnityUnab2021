using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRaycast : MonoBehaviour
{
    public Transform canon;
    public LineRenderer line;
    public LayerMask enemy;
    public int damage = 1;
    
    public void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(canon.position, canon.forward, out hit, enemy))
        {
            line.SetPosition(0, canon.position);
            line.SetPosition(1, hit.point);
            HP_Character hp= hit.transform.GetComponent<HP_Character>();
            if(hp != null)
            {
                hp.TakeDamage(damage);
            }
            
        }
    }
    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Shoot();
        }
    }
}
