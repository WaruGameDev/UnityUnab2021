using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCatClass : MonoBehaviour
{
    public CatClass.CAT_CLASE claseACambiar;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CatClass catClass = other.GetComponent<CatClass>();
            catClass.ChangeClass(claseACambiar);
        }
    }
}
