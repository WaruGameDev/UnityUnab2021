using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoverAPosion : MonoBehaviour
{
    public RectTransform destino;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<RectTransform>().DOMove(destino.position, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
