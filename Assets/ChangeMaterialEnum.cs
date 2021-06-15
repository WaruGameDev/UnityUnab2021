using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialEnum : MonoBehaviour
{
    public enum MATERIALES_A_CAMBIAR
    {
        MATERIAL_UNO,
        MATERIAL_DOS,
        MATERIAL_TRES
    }
    public MATERIALES_A_CAMBIAR mat;
    

    public List<Material> mats;
    private void Update()
    {
        ChangeMaterial();
    }

    


    public void ChangeMaterial()
    {
        switch(mat)
        {
            case MATERIALES_A_CAMBIAR.MATERIAL_UNO:
                GetComponent<Renderer>().material = mats[0];
                break;
            case MATERIALES_A_CAMBIAR.MATERIAL_DOS:
                GetComponent<Renderer>().material = mats[1];
                break;
            case MATERIALES_A_CAMBIAR.MATERIAL_TRES:
                GetComponent<Renderer>().material = mats[2];
                break;

        }
    }
}
