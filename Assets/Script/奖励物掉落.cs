﻿using UnityEngine;
 using System.Collections;
 
 public class 奖励物掉落 : MonoBehaviour {
 
 
     public float 距离=5;
     public float 掉落Speed = 5;
     private Transform cameraTransform;
 	// Use this for initialization
 	void Start () {
         cameraTransform = GameObject.Find("Main Camera").transform;
 	}
 	
 	// Update is called once per frame
 	void Update () {
         if (cameraTransform.position.y + 距离 > transform.position.y)
             GetComponent<Rigidbody2D>().velocity = Vector3.down * 掉落Speed;
 	}
 }
