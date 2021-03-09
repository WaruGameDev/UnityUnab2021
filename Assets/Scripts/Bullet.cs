using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        HP_Character hp = other.GetComponent<HP_Character>();
        if (hp == null)
            return;
        hp.TakeDamage(damage);
    }
}
