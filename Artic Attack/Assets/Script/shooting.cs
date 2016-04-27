﻿using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour {

	float shoottimer = 0f;
	public bool canshoot;
	Vector3 projxy;
	Quaternion projquat;
	public GameObject proj;

	void Start () {

		canshoot = true;
		projquat = new Quaternion(0, 0, 0, 0);

	}
	

	void Update () {

		projxy = gameObject.transform.position;

		print (canshoot);
		print (shoottimer);

		if (Input.GetKeyDown (KeyCode.Z) && canshoot == true) {

			GetComponentInParent<Animator> ().SetBool ("isShooting", true);
			canshoot = false;
			Instantiate (proj, projxy, projquat);
			shoottimer = 35f;

		}

		if(canshoot == false) {
			GetComponentInParent<Animator> ().SetBool ("isShooting", false);
		}

		if (shoottimer < 0) {
			canshoot = true;
		} else {
			--shoottimer;
		}
	}
}
