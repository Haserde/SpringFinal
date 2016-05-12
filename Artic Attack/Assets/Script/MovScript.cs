using UnityEngine;
using System.Collections;

public class MovScript : MonoBehaviour {

	private int layerMask = 1 << 8;

	float movspd = 13f;
	float xspd;
	public float jumpspd = 1000f;
	bool canjump;
	bool canl = true;
	bool canr = true;
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
		RaycastHit2D hit3 = Physics2D.Raycast(new Vector2(transform.position.x,transform.position.y), -Vector2.up,2.0f,layerMask);

		if (hit1.collider != null || hit2.collider != null || hit3.collider != null) {
			canjump = true;
		} else {
			canjump = false;
		} 
			
		RaycastHit2D hit4 = Physics2D.Raycast(new Vector2(transform.position.x,transform.position.y+1f), Vector2.right,1.2f,layerMask);
		RaycastHit2D hit5 = Physics2D.Raycast(new Vector2(transform.position.x,transform.position.y), Vector2.right,1.2f,layerMask);
		RaycastHit2D hit6 = Physics2D.Raycast(new Vector2(transform.position.x,transform.position.y-1f), Vector2.right,1.2f,layerMask);

		RaycastHit2D hit7 = Physics2D.Raycast(new Vector2(transform.position.x,transform.position.y+1f), Vector2.left,1.2f,layerMask);
		RaycastHit2D hit8 = Physics2D.Raycast(new Vector2(transform.position.x,transform.position.y), Vector2.left,1.2f,layerMask);
		RaycastHit2D hit9 = Physics2D.Raycast(new Vector2(transform.position.x,transform.position.y-1f), Vector2.left,1.2f,layerMask);

		if (hit4.collider != null || hit5.collider != null || hit6.collider != null) {
			canr = false;
		} else {
			canr = true;
		}

		if (hit7.collider != null || hit8.collider != null || hit9.collider != null) {
			canl = false;
		} else {
			canl = true;
		}


	}

	void Update () {

		if (Input.GetAxis ("Horizontal") > 0) {
			if (canr == true) {
				xspd = Input.GetAxis("Horizontal") * movspd;
				rb.velocity = new Vector2 (xspd, rb.velocity.y);
			} else {
				xspd = 0;
			}
		}

		if (Input.GetAxis ("Horizontal") < 0) {
			if (canl == true) {
				xspd = Input.GetAxis ("Horizontal") * movspd;
				rb.velocity = new Vector2 (xspd, rb.velocity.y);
			} else {
				xspd = 0;
			}
		}


		if (Input.GetButtonDown ("Jump") && canjump) {
			rb.AddForce (new Vector2 (0, jumpspd));
		}
			
	}
		
}