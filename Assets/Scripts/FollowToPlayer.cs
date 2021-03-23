using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowToPlayer : MonoBehaviour
{
    public bool everFollowing;
    public Vector2 direction;
    public float speed = 300;
    public Rigidbody2D rb;

    private GameObject player;
    // Start is called before the first frame update
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        DirectionToPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if(everFollowing)
        {
            DirectionToPlayer();
        }
        //transform.Translate(direction * speed * Time.deltaTime);
        rb.velocity = new Vector2(direction.x, direction.y) * speed * Time.fixedDeltaTime;
    }
    void DirectionToPlayer()
    {
        direction = (player.transform.position - transform.position).normalized;
    }
}
