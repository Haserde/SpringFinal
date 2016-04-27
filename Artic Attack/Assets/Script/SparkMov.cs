using UnityEngine;
using System.Collections;

public class SparkMov : MonoBehaviour {

	float sparkspd = 0.4f;
	bool spawned = true;

	void Start () {

	}
	

	void Update () {
	
		if (spawned == true) {

			if (Input.GetAxis ("Horizontal") > 0) {

				sparkspd = sparkspd * 1;

			} else if (Input.GetAxis ("Horizontal") < 0) {
				sparkspd = -sparkspd;
			}

			spawned = false;
		}

		gameObject.transform.position = gameObject.transform.position + new Vector3 (sparkspd, 0, 0);
	}
}
