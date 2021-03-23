using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementChar : MonoBehaviour
{
    public Transform transformAMover;
    public float speed = 5;
    public Vector2 directionPlayer = new Vector2(1,0);
    public bool mouse;
    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.right * x * speed * Time.fixedDeltaTime);
        //transform.Translate(Vector3.up * y * speed * Time.fixedDeltaTime);
       
        rb.velocity = new Vector2(x, y) *speed * Time.fixedDeltaTime;


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
