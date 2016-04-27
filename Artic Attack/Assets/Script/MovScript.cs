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
		canjump = false;

	}
	

	void Update () {

		xspd = Input.GetAxis("Horizontal") * movspd;

		rb.velocity = new Vector2 (xspd, rb.velocity.y);

		if (Input.GetKeyDown (KeyCode.X) && canjump == true) {

			yspd = jumpspd;

			rb.velocity = rb.velocity + new Vector2 (rb.velocity.x, yspd);

			canjump = false;

		}
			
	}

	void OnCollisionEnter2D (Collision2D  col) {

		if(col.gameObject.CompareTag("ground")) {
			canjump = true;
		}

	}

	void OnTriggerEnter2D (Collider2D col) {

	}
		
}