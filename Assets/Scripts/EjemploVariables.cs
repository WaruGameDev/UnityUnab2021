using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploVariables : MonoBehaviour
{
    EjemploVariables ejemploVariables;

    public string textoEjemplo = "hola";
    public int numeroEnteroEjemplo = 55;
    public float numeroDecimalEjemplo = 5.5f;
    public bool verdaderoOFalso = true;

    public void FuncionEjemplo()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        ejemploVariables.FuncionEjemplo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
