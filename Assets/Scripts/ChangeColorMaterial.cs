using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorMaterial : MonoBehaviour
{
    public List<Renderer> coloresACambiar;
    public Material colorCambio;
    public int index;


    private void Start()
    {
        foreach(Transform t in transform)
        {
            coloresACambiar.Add(t.GetComponent<Renderer>());
        }
        //foreach(Renderer r in coloresACambiar)
        //{
        //    r.material = colorCambio;
        //}
        for (int i = 0; i < coloresACambiar.Count; i++)
        {
            //if(i%2 == 0)
            //{
            //    coloresACambiar[i].material = colorCambio;
            //}
            if(i > coloresACambiar.Count/2)
            {
                coloresACambiar[i].material = colorCambio;
            }
            
        }
    }
}
