using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;

public class DialogoManager : MonoBehaviour
{
    public static DialogoManager instance;
    public TextMeshProUGUI textoDialogo;
    public List<string> dialogos;
    
    public RectTransform dialogoPanel, puntoGuia;
    private Vector2 originalPos;


    private void Awake()
    {
        instance = this;
        
    }
    private void Start()
    {
        originalPos = dialogoPanel.position;
    }

    public void ShowDialogo(int i)
    {
        dialogoPanel.DOMove(puntoGuia.position, .5f);
        textoDialogo.text = dialogos[i];
    }
    public void HideDialogo()
    {
        
        dialogoPanel.DOMove(originalPos, .5f);        
    }

}
