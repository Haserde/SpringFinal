using UnityEngine;
using System.Collections;

public class MovScript : MonoBehaviour {


	float movspd = 20f;
	float xspd;
	float jumpspd = 20f;
	float yspd;
	bool canjump;
	int direction;
	Rigidbody2D rb;
	Rigidbody2D colrb;



	void Start () {

		rb = GetComponent<Rigidbody2D> ();

	}
	

	void Update () {

		print (canjump);

		xspd = Input.GetAxis("Horizontal") * movspd;

		rb.velocity = new Vector2 (xspd, rb.velocity.y);

		if (Input.GetKeyDown (KeyCode.X)) {

			yspd = jumpspd;

			rb.velocity = rb.velocity + new Vector2 (rb.velocity.x, yspd);

			canjump = false;

		}
			
	}

	void OnCollisionEnter2D (Collision2D  col) {

	}

	void OnTriggerEnter2D (Collider2D col) {

	}
		
}