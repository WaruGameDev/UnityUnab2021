using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlatform : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 10;
    private Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask plataformas;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        Move(x * speed * Time.deltaTime);
        if(Input.GetButtonDown("Jump") && IsGround())
        {
            Jump();
        }
        Debug.DrawRay(groundCheck.position, -groundCheck.up * 0.1f, Color.red);
    }
    public void Move(float x)
    {
        rb.velocity = new Vector2(x, rb.velocity.y);
    }
    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
    public bool IsGround()
    {

        return Physics2D.CircleCast(groundCheck.position, 0.1f, -groundCheck.up, plataformas);
    }
}
