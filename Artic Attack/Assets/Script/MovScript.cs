using UnityEngine;
using System.Collections;

public class MovScript : MonoBehaviour {


	float movspd = 13f;
	float xspd;
	float jumpspd = 1000f;
	bool canjump;
	int direction;
	Rigidbody2D rb;
	Rigidbody2D colrb;

	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();
		canjump = false;

	}
	

	void Update () {

		print (Input.GetAxis ("Vertical"));

		print (canjump);

		xspd = Input.GetAxis("Horizontal") * movspd;

		rb.velocity = new Vector2 (xspd, rb.velocity.y);

		if (Input.GetButtonDown("Jump") && canjump) {
			
			rb.AddForce (new Vector2(0, jumpspd));
			canjump = false;

		}
			
	}

	void OnCollisionEnter2D (Collision2D  col) {

		if(col.gameObject.CompareTag("ground")) {
			canjump = true;
		}

	}

	void OnCollisionStay2D (Collision2D  col) {

		if(col.gameObject.CompareTag("ground")) {
			canjump = true;
		}

	}

	void OnCollisionExit2D (Collision2D  col) {

		if(col.gameObject.CompareTag("ground")) {
			canjump = false;
		}

	}
		
}