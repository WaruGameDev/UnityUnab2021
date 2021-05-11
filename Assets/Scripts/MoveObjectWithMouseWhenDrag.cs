using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectWithMouseWhenDrag : MonoBehaviour
{
    public Transform player;
    private void OnMouseDrag()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 10;
        player.position = mousePos;

    }
}
