using UnityEngine;
using System.Collections;

public class SparkMov : MonoBehaviour {

	float sparkspd = 10f;
	float lifetime = 200f;
	bool spawned = true;
	public int dir; 
	Rigidbody2D sparkrb;
	public GameObject source;

	void Start () {

		sparkrb = GetComponent<Rigidbody2D> ();
		dir = source.GetComponent<shooting> ().dir;

	}
	

	void Update () {

		if (spawned == true) {

			sparkrb.velocity = sparkrb.velocity + new Vector2 (sparkspd, sparkrb.velocity.y);

			spawned = false;
		}

		--lifetime;

		if (lifetime < 0) {

			Destroy (gameObject);

		}
	}
}
