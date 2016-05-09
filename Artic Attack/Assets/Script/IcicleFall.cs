using UnityEngine;
using System.Collections;

public class IcicleFall : MonoBehaviour {


	float fallspd = 0f;
	bool spawned = true;
	Rigidbody2D icerb;

	void Start () {
	
		icerb = GetComponent<Rigidbody2D> ();
	}

	void Update () {
	
		if (spawned == true) {
			icerb.velocity = icerb.velocity + new Vector2 (fallspd, icerb.velocity.y);
			spawned = false;
		}
	}

	void OnCollisionEnter2D (Collision2D col) {

		if(col.gameObject.name =="PlayerCharacter") {

			print (col.gameObject.name);

			Destroy(col.gameObject);

		}
	}
}