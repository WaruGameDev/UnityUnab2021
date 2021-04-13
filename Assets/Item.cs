using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string nameItem;

    public enum TIPO_MATERIAL
    {
        MADERA = 0,
        PIEDRA = 1,
        TIERRA = 2
    }
    public TIPO_MATERIAL tipoMaterial;

    private void Start()
    {
        tipoMaterial = (TIPO_MATERIAL)Random.Range(0, 3);
        ActualizarColor();
    }
    public void ActualizarColor()
    {
        //GetComponent<SpriteRenderer>().color = Color.yellow;
      
        switch(tipoMaterial)
        {
            case TIPO_MATERIAL.MADERA:
                GetComponent<SpriteRenderer>().color = Color.yellow;
                break;
            case TIPO_MATERIAL.PIEDRA:
                GetComponent<SpriteRenderer>().color = Color.gray;
                break;
            case TIPO_MATERIAL.TIERRA:
                GetComponent<SpriteRenderer>().color = Color.green;
                break;
        }
        
    }

    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            tipoMaterial = TIPO_MATERIAL.MADERA;
            ActualizarColor();
        }
    }

}
