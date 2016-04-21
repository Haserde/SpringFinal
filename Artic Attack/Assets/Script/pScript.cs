using UnityEngine;
using System.Collections;

public class pScript : MonoBehaviour {

	private float xscale;

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

		if (Input.GetKeyDown (KeyCode.X)) {
			GetComponent<Animator> ().SetBool ("isShooting", true);
		} 


	}
		
}
