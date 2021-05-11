using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolectar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            ManagerObject.instance.objetosScena.Remove(other.gameObject);
            other.gameObject.SetActive(false);

        }
    }
}
