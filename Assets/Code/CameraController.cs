﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {
        this.player = GameObject.Find("cat");
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 playerPos = this.player.transform.position;
        if (playerPos.y > 0)
        {
            transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
        }
	}

    public void SetInit()
    {
        transform.position = new Vector3(0, 0, -10);
    }
}
