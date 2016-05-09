using UnityEngine;
using System.Collections;

public class MovScript : MonoBehaviour {

	private int layerMask = 1 << 8;

	float movspd = 13f;
	float xspd;
	float jumpspd = 1250f;
	bool canjump;
	int direction;
	Rigidbody2D rb;
	Rigidbody2D colrb;


	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();
		canjump = false;

	}

	void FixedUpdate() {

		RaycastHit2D hit1 = Physics2D.Raycast(new Vector2(transform.position.x+.8f,transform.position.y), -Vector2.up,2.0f,layerMask);
		RaycastHit2D hit2 = Physics2D.Raycast(new Vector2(transform.position.x-.8f,transform.position.y), -Vector2.up,2.0f,layerMask);

		print ("hit: " + (hit2.collider != null));

		if (hit1.collider != null || hit2.collider != null) {
			canjump = true;
		} else {
			canjump = false;
		} 

	}

	void Update () {


		xspd = Input.GetAxis("Horizontal") * movspd;

		rb.velocity = new Vector2 (xspd, rb.velocity.y);

		if (Input.GetButtonDown("Jump") && canjump) {
			rb.AddForce (new Vector2(0, jumpspd));

		}
			
	}
		
}