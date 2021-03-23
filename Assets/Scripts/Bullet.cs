using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;
    public float speed = 9;
    public Vector2 direction;
    public string target;
    public float timeToDestroy = 3;

    private void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);        
    }

    public void MoveBullet(Vector2 dir)
    {
        direction = dir;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag(target))
        {
            HP_Character hp = other.GetComponent<HP_Character>();
            if (hp == null)
                return;
            hp.TakeDamage(damage);
            Destroy(gameObject);
        }  
        if(other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
    
}
