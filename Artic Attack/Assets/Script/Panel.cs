using UnityEngine;
using System.Collections;

public class Panel : MonoBehaviour {

	public bool On;
	public GameObject thingToSwitch;

	void Start() {

	}

	void Update() {

		if (On == true) {

			GetComponent<Animator> ().SetBool ("On", true);

		}

		if (On == false) {

			GetComponent<Animator> ().SetBool ("On", false);

		}

	}

	void OnTriggerEnter2D (Collider2D col) {

		if (col.gameObject.CompareTag ("spark")) {

			if (On == true) {
				thingToSwitch.SendMessage ("turnOff", false);
				On = false;
			} else {
				thingToSwitch.SendMessage ("turnOn", true);
				On = true;
			}

		}

	}

}
