using UnityEngine;
using System.Collections;

public class canvasTrig : MonoBehaviour {

	public GameObject can;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			can.SetActive (true);
		} else {
			can.SetActive (false);
		}
	
	}
}
