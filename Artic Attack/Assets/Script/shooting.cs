using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour {

	public float shoottimer = 0f;
	bool canshoot;
	public int dir;
	Vector3 projxy;
	Quaternion projquat;
	public GameObject proj;

	void Start () {

		canshoot = true;
		projquat = new Quaternion(0, 0, 0, 0);

	}
	

	void Update () {

		projxy = gameObject.transform.position;

		if (Input.GetButtonDown("Fire1") && canshoot == true) {

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

		if (Input.GetAxis ("Horizontal") > 0) {
			dir = 1;
		}

		if (Input.GetAxis ("Horizontal") < 0) {
			dir = -1;
		}
	}
}
