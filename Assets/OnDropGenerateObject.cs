using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class OnDropGenerateObject : MonoBehaviour
{
    public GameObject dropObject;
    public int cantidad = 5;

    public CinemachineVirtualCamera cam;
    public void GenerateObjet()
    {
        if(cantidad > 0)
        {
            Vector3 posInWorld = Camera.main.ScreenToWorldPoint(transform.position);
            posInWorld.z = 0;
            Instantiate(dropObject, posInWorld, Quaternion.identity);
            cantidad--;
        }
        else
        {
            Debug.Log("no me quedan objetos");
        }
        
    }
    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            cam.Priority = 999;
        }
    }
}
