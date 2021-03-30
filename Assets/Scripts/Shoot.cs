﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;    
    public Color colorBullet;
    public string target;
    public bool isPlayer;

    private void Start()
    {
        if(!isPlayer)
        {
            StartCoroutine(ShootFourDirection());
        }
    }

    private void Update()
    {
        if(isPlayer)
        {
            if (Input.GetButtonDown("Jump") || Input.GetButtonDown("Fire1"))
            {
                ShootBullet(GetComponent<MovementChar>().directionPlayer);
            }
        }
        
    }
    public void ShootBullet(Vector2 dir)
    {
        FeedbackManager.sFeedbackManager.ScreenShake(0.5f, 0.1f);
        GameObject bulletGO = Instantiate(bullet, transform.position, Quaternion.identity);
        bulletGO.GetComponent<Bullet>().target = target;
        bulletGO.GetComponent<Bullet>().MoveBullet(dir);
        bulletGO.GetComponent<SpriteRenderer>().color = colorBullet;
    }

    IEnumerator ShootEnemy()
    {
        while(true)
        {
            yield return new WaitForSeconds(3);
            ShootBullet(GetComponent<FollowToPlayer>().direction);
        }
        //yield break;
    }
    IEnumerator ShootFourDirection()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            ShootBullet(GetComponent<FollowToPlayer>().direction);
            
        }
    }
}