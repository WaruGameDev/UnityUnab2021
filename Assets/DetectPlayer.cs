using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class DetectPlayer : MonoBehaviour
{
    public List<GameObject> listaIsaac;
    public CinemachineVirtualCamera vc;

    public int numeroEntero;
    public float numeroDecimal;
    public string texto;
    public bool verdaderoYFalso;
    
    // Start is called before the first frame update
    void Start()
    {
        vc.Priority = 100;
        for (int i = 0; i < listaIsaac.Count; i++)
        {
            if(listaIsaac[i].transform.CompareTag("Player"))
            {
                listaIsaac.Remove(listaIsaac[i]);
            }
        }
        if(FuncionTipo(4) == 5.5f)
        {
            
        }
    }
    float FuncionTipo(int i)
    {
        return Mathf.Pow(2,2);
    }

    
}
