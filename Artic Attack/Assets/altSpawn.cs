using UnityEngine;
using System.Collections;

public class altSpawn : MonoBehaviour {

	public GameObject player1;
	Vector3 newPos;
	public string nextLevel;


	void Start () {
		newPos = GameObject.Find ("dest").transform.position;
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			Application.LoadLevel (nextLevel);
			transform.position = newPos;
		}
	}
}