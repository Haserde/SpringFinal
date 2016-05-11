using UnityEngine;
using System.Collections;

public class startgame : MonoBehaviour {

	public string nextLevel;

	void Start () {
	
	}
	

	void Update () {
	
		if (Input.GetButtonDown("Jump")) {
			Application.LoadLevel (nextLevel);
		}


	}
}
