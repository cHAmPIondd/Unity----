﻿using UnityEngine;
 using System.Collections;
 
 public class 云雾卷轴 : MonoBehaviour {
 
     public float Speed;
     private float 起点;
     public float 横向距离;
 	// Use this for initialization
 	void Start () {
         起点 = this.gameObject.transform.position.x;
 	}
 	
 	// Update is called once per frame
 	void Update () {
         this.gameObject.transform.position += Vector3.left*Speed;
         if (this.gameObject.transform.position.x < 起点 - 横向距离)
             this.gameObject.transform.position = new Vector3(起点, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
 	}
 }
