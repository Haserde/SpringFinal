using UnityEngine;
using System.Collections;

public class FallMov : MonoBehaviour {

	public bool activ = false;
	public float fallspd;
	Rigidbody2D rb;

	void Start () {
	
		rb = GetComponent<Rigidbody2D> ();

	}

	void Update () {
	
		if (activ) {
			
			rb.isKinematic = false;
			rb.AddForce (new Vector2 (0, fallspd));

		}

	}

	public void Activ (bool act) {

		activ = act;

	}

}
