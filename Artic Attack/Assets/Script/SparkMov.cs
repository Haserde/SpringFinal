using UnityEngine;
using System.Collections;

public class SparkMov : MonoBehaviour {


	float lifetime = 20f;
	bool spawned = true;
	public GameObject source;

	void Start () {

	}
	

	void Update () {

		if (spawned == true) {

			spawned = false;
		}



		--lifetime;

		if (lifetime < 0) {

			Destroy (gameObject);

		}
	}
}
