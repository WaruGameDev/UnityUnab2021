using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerObject : MonoBehaviour
{
    public List<GameObject> objetosScena;
    public static ManagerObject instance;

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(objetosScena.Count <= 0)
        {
            print("Perdiste");
        }
    }
}
