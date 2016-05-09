using UnityEngine;
using System.Collections;

public class pScript : MonoBehaviour {

	private float xscale;
	bool jump;

	// Use this for initialization
	void Start () {

		xscale = transform.localScale.x;


	}
	
	// Update is called once per frame
	void Update () {

		/* Animation Triggers */

		if (Input.GetAxis ("Horizontal") < 0) {
			transform.localScale = new Vector3 (-xscale, transform.localScale.y, transform.localScale.z);
		}

		if (Input.GetAxis ("Horizontal") > 0) {
			transform.localScale = new Vector3 (xscale, transform.localScale.y, transform.localScale.z);
		}

		if (Input.GetAxis ("Horizontal") > 0 || Input.GetAxis ("Horizontal") < 0) {
			GetComponent<Animator> ().SetBool ("isWalking", true);
		} else {
			GetComponent<Animator> ().SetBool ("isWalking", false);
		}

		if (GetComponentInChildren<shooting> ().canshoot == true) {
			if (Input.GetKeyDown (KeyCode.Z)) {
				GetComponent<Animator> ().SetBool ("isShooting", true);
			}
		} 

		if (Input.GetButtonDown ("Jump")) {
			GetComponent<Animator> ().SetBool ("isJumping", true);
		} 

	}

	void OnCollisionEnter2D(Collision2D col) {

		if (col.gameObject.CompareTag ("ground")) {
			GetComponent<Animator> ().SetBool ("isJumping", false);
		}

	}
		
	void OnCollisionStay2D(Collision2D col) {

		if (col.gameObject.CompareTag ("ground")) {
			GetComponent<Animator> ().SetBool ("isJumping", false);
		}

	}
}
