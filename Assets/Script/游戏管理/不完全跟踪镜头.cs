﻿using UnityEngine;
 using System.Collections;
 
 public class 不完全跟踪镜头 : MonoBehaviour {
 
     private Transform cameraTransform;
     public float 镜头初始x;
     public float 物品初始x;
     public float 跟踪百分比;
     void Start()
     {
         cameraTransform = GameObject.Find("Main Camera").transform;
         物品初始x = transform.position.x;
         镜头初始x = cameraTransform.position.x;
     }
 
     // Update is called once per frame
     void Update()
     {
         this.gameObject.transform.position = new Vector3((cameraTransform.position.x - 镜头初始x)*跟踪百分比+物品初始x, transform.position.y, 0);
     }
 }
