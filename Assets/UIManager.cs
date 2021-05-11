using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject uiObjectReference;
    public RectTransform panel;
    public Canvas canvas;

    private void Awake()
    {
        instance = this;
    }

    public void GenerateUiElement(Vector3 pos, Sprite newSprite)
    {
        GameObject uiGO = Instantiate(uiObjectReference, pos, Quaternion.identity);
        uiGO.GetComponent<Image>().sprite = newSprite;
        uiGO.transform.SetParent(canvas.transform);
        uiGO.transform.DOMove(panel.position, 0.5f);
    }
}
