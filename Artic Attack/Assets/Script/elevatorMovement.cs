﻿using UnityEngine;
using System.Collections;

public class elevatorMovement : MonoBehaviour {
	public float speed;
	Animator anim;

	// Use this for initialization

	void Start () {
		anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject){
			transform.Translate (Vector2.up * speed, Space.World);
			anim.SetBool ("isMoving", true);
			print ("hello");
		}
	}
}
