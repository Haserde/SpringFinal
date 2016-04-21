using UnityEngine;
using System.Collections;

public class MovScript : MonoBehaviour {


	float movspd = 30f;
	float xspd;
	float jumpspd = 55f;
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
			
	}

	void OnCollisionEnter2D (Collision2D  col) {

	}

	void OnTriggerEnter2D (Collider2D col) {

	}
		
}