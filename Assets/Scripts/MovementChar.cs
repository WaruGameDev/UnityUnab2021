using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementChar : MonoBehaviour
{
    public Transform transformAMover;
    public float speed = 5;
    public Vector2 directionPlayer = new Vector2(1,0);
    public bool mouse;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * x * speed * Time.deltaTime);
        transform.Translate(Vector3.up * y * speed * Time.deltaTime);

        //gamepad mode
        //float dirPlayerX = Mathf.Round(Input.GetAxisRaw("Horizontal"));
        //float dirPlayerY = Mathf.Round(Input.GetAxisRaw("Vertical"));        
        //if (dirPlayerX != 0 || dirPlayerY != 0)
        //{
        //    directionPlayer = new Vector2(dirPlayerX, dirPlayerY);
        //}

        if(mouse)
        {
            float dirPlayerX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            float dirPlayerY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
            Vector2 dir = (new Vector2(dirPlayerX, dirPlayerY) - (Vector2)transform.position).normalized;
            directionPlayer = dir;
        }
        else
        {
            float dirPlayerX = 10* (Input.GetAxisRaw("Mouse X"));
            float dirPlayerY = 10* (Input.GetAxisRaw("Mouse Y"));
            if (dirPlayerX != 0 || dirPlayerY != 0)
            {
                directionPlayer = (new Vector2(dirPlayerX, dirPlayerY)).normalized;
            }
        }


    }

}
