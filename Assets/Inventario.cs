using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public List<GameObject> inventario;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {
            inventario.Add(other.gameObject);
            other.gameObject.SetActive(false);
        }
    }

}
