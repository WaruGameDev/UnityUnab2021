using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndUI : MonoBehaviour
{

    private void OnMouseDown()
    {
        Vector3 posObjectUI = Camera.main.WorldToScreenPoint(transform.position);
        UIManager.instance.GenerateUiElement(posObjectUI, GetComponent<SpriteRenderer>().sprite);
        gameObject.SetActive(false);
    }
}
