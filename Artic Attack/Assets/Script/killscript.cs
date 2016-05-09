using UnityEngine;
using System.Collections;

public class killscript : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col) {

		if (col.gameObject.CompareTag ("Player")) {

			Destroy (col.gameObject);

		}

	}
}
