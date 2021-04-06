using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public static DoorManager staticDoorManager;
    public GameObject door1, door2;
    public int enemigosDerrotados;

    private void Awake()
    {
        staticDoorManager = this;
    }


    private void Update()
    {
        if(enemigosDerrotados >=6)
        {
            door1.SetActive(false);
        }
        if(enemigosDerrotados >= 9)
        {
            door2.SetActive(false);
        }
    }


}
