using UnityEngine;
using System.Collections;

public class package : MonoBehaviour {

	public GameObject detector;

	void Start () {
	
	}
	

	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col) {

		if (col.gameObject.CompareTag ("Player")) {

			havePackage.pckge = true;

			Destroy (gameObject);

		}

	}
}
