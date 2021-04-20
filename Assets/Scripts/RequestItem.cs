using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestItem : MonoBehaviour
{
    //public string itemNameRequest;
    public Item.TIPO_MATERIAL itemRequest;
    public bool ready;
    public List<string> characterDialogue;

    private void Update()
    {
        if(ready)
        {
            transform.Rotate(Vector3.forward * 1000);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        DialogoManager.instance.dialogos = characterDialogue;
        if (other.CompareTag("Player"))
        {
            if(!ready)
            {
                DialogoManager.instance.ShowDialogo(0);
                Inventario inventario = other.GetComponent<Inventario>();
                foreach (GameObject g in inventario.inventario)
                {
                    if (g.GetComponent<Item>().tipoMaterial == itemRequest)
                    {
                        ready = true;
                        inventario.inventario.Remove(g);
                        DialogoManager.instance.ShowDialogo(1);
                        return;
                    }
                }
            }
            else
            {
                DialogoManager.instance.ShowDialogo(2);
            }            
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DialogoManager.instance.HideDialogo();
        }
    }
}
