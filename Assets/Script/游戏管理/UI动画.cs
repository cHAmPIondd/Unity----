﻿using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 public class UI动画 : MonoBehaviour {
 
     public Sprite[] 动画;
     private float timer = 0;
     private Image Image;
     public float 速度;
     void Start () {
         Image = this.GetComponent<Image>();
 	}
 
     void OnDisable()
     {
         timer = 0;
     }
 
 	void Update () {
         timer += Time.unscaledDeltaTime;
         int Index = (int)(timer / 速度);
         Image.sprite = 动画[Index % 动画.Length];
 	}
 }
