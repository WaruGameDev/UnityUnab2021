using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject burbuja, bomb;

    
    public enum POWERUP_TYPES
    {
        BOMB,
        BUBBLE
    }
    public POWERUP_TYPES powerUp = POWERUP_TYPES.BUBBLE;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            switch(powerUp)
            {
                case POWERUP_TYPES.BUBBLE:
                    Instantiate(burbuja, other.transform);
                    Destroy(gameObject);
                    break;
                case POWERUP_TYPES.BOMB:
                    Instantiate(bomb, other.transform.position, Quaternion.identity);
                    Destroy(gameObject);
                    break;
            }
            
            
        }
    }
}
