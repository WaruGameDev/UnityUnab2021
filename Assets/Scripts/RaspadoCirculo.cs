using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaspadoCirculo : MonoBehaviour
{
    SpriteMask spriteMask;
    private void Start()
    {
        spriteMask = GetComponent<SpriteMask>();
    }
    private void OnMouseEnter()
    {
        if(Input.GetButton("Fire1"))
        {
            spriteMask.enabled = true;
            GetComponent<Collider2D>().enabled = false;
            
        }
    }

}
