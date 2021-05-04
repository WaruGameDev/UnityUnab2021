using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raspado : MonoBehaviour
{
    public GameObject raspadoGO;
    private void OnMouseDrag()
    {
        //if(Mathf.Abs(Input.GetAxis("Mouse X"))>0 || Mathf.Abs(Input.GetAxis("Mouse Y")) > 0)
        //{
            Vector2 posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(raspadoGO, posMouse, Quaternion.identity);
        //}
        
    }
    
}
