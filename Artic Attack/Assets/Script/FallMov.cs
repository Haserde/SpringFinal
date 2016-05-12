using UnityEngine;
using System.Collections;

public class FallMov : MonoBehaviour {

	bool activ = false;
	public float fallspd;
	Rigidbody2D rb;

	void Start () {
	
		rb = GetComponent<Rigidbody2D> ();

	}

	void Update () {
	
		if (activ) {
			
			rb.isKinematic = false;
			rb.AddForce (new Vector2 (0, fallspd));

		}

	}

	void OnCollisionEnter2D (Collision2D col) {

		if (col.gameObject.CompareTag ("Player")) {

			activ = true;

		}

	}

}
