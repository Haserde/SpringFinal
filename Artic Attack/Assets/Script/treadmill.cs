using UnityEngine;
using System.Collections;

public class treadmill : MonoBehaviour {


	float turnspd = 5f;
	bool turn;

	void Start () {

	}

	void Update () {


		if (turn == true) {
			turnspd = 5f;
			GetComponent<Animator> ().SetBool ("goL", true);
		}
		if (turn == false) {
			turnspd = -turnspd;
			GetComponent<Animator> ().SetBool ("goL", false);
		}
	
	}

	void turnOn(bool isOn) {
		turn = isOn;
	}

	void turnOff(bool isOn) {
		turn = isOn;
	}

	void OnCollisionStay2D (Collision2D col) {

		col.gameObject.GetComponent<Rigidbody2D> ().velocity = col.gameObject.GetComponent<Rigidbody2D> ().velocity
		+ new Vector2 (turnspd, col.gameObject.GetComponent<Rigidbody2D> ().velocity.y);

	}
}
