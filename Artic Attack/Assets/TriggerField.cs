using UnityEngine;
using System.Collections;

public class TriggerField : MonoBehaviour {

	public GameObject[] Wires;

	void Start () {

	}

	void Update () {

	}

	void OnTriggerEnter2D (Collider2D col) {

		if (col.gameObject.CompareTag ("Player")) {
			foreach (GameObject wire in Wires) {
				wire.SendMessage ("Activ", true);
			}

			Destroy (gameObject);

		} 

	}
}
