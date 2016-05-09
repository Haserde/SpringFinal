using UnityEngine;
using System.Collections;

public class moveScene : MonoBehaviour {
	public string nextLevel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject) {
			Application.LoadLevel (nextLevel);
		}
		print ("hit");
	}
}
