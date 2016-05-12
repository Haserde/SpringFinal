using UnityEngine;
using System.Collections;

public class moveScene : MonoBehaviour {
	public string nextLevel;
	public bool dir;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag("Player")) {
			if (dir == true) {
				Application.LoadLevel (nextLevel);
				spawner.dir = true;

			}
			if (dir == false) {
				Application.LoadLevel (nextLevel);
				spawner.dir = false;
			}
		}

	}
}
