using UnityEngine;
using System.Collections;

public class treadmill : MonoBehaviour {

	public GameObject swtch;
	float turnspd = 5f;
	bool turn;

	void Start () {

	}

	void Update () {

		turn = swtch.GetComponent<Panel> ().On;

		if (turn == true) {
			turnspd = 5f;
			GetComponent<Animator> ().SetBool ("goL", true);
		}
		if (turn == false) {
			turnspd = -turnspd;
			GetComponent<Animator> ().SetBool ("goL", false);
		}
	
	}

	void OnCollisionStay2D (Collision2D col) {

		col.gameObject.GetComponent<Rigidbody2D> ().velocity = col.gameObject.GetComponent<Rigidbody2D> ().velocity
		+ new Vector2 (turnspd, col.gameObject.GetComponent<Rigidbody2D> ().velocity.y);

	}
}
