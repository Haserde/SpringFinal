using UnityEngine;
using System.Collections;

public class activate : MonoBehaviour {

	public bool activ = false;
	public string nextLevel;
	float timer = 100f;

	void Start () {
	
	}

	void Update () {
	
		if (activ) {

			timer--;
			gameObject.GetComponent<Animator> ().SetBool ("fail", true);

		}

		if (timer < 0) {

			Application.LoadLevel (nextLevel);

		}

	}

	public void Activ () {

		activ = true;

	}
}
