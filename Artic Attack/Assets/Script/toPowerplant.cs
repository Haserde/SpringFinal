using UnityEngine;
using System.Collections;

public class toPowerplant : MonoBehaviour {

	public bool gotpckage;
	public string nextLevel;

	void Start () {
	


	}

	void Update () {

		gotpckage = havePackage.pckge;

	}

	void OnTriggerEnter2D(Collider2D other){
		
		if (gotpckage == true) {

			if (other.gameObject.CompareTag ("Player")) {
				Application.LoadLevel (nextLevel);
			}

		}
	}
}
