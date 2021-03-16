using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowToPlayer : MonoBehaviour
{
    public bool everFollowing;
    public Vector2 direction;
    public float speed = 4;

    private GameObject player;
    // Start is called before the first frame update
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Start()
    {
        
        DirectionToPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if(everFollowing)
        {
            DirectionToPlayer();
        }
        transform.Translate(direction * speed * Time.deltaTime);
    }
    void DirectionToPlayer()
    {
        direction = (player.transform.position - transform.position).normalized;
    }
}
