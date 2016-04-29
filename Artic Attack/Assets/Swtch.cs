using UnityEngine;
using System.Collections;

public class Swtch : MonoBehaviour {

	public GameObject[] Wires;

	void Start () {
	
	}

	void Update () {
	

	}

	void OnTriggerEnter2D (Collider2D col) {

		if (col.gameObject.CompareTag ("spark")) {
			foreach (GameObject wire in Wires) {
				wire.SendMessage ("PosNumber", 1);
			}
		} 

	}
}
