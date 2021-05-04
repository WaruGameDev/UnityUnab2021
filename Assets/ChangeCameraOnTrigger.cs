using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeCameraOnTrigger : MonoBehaviour
{
    public CinemachineVirtualCamera cam;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            cam.Priority = 99;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cam.Priority = 0;
        }
    }

}
