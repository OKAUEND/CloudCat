﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody2D rigid2d;
    Animator animation;
    float jumpForce = 680.0f;
    float WalkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

	// Use this for initialization
	void Start () {
        this.rigid2d = GetComponent<Rigidbody2D>();
        this.animation = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2d.AddForce(transform.up * this.jumpForce);
        }

        //左右移動
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(this.rigid2d.velocity.x);

        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2d.AddForce(transform.right * key * this.WalkForce);
        }
        if( key != 0 )
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        this.animation.speed = speedx / 2.0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if()

        Debug.Log("ゴール!!");
    }

    private bool IsOutofScreen(string tag)
    {
        return true;
    }
}
