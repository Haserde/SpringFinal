using UnityEngine;
using System.Collections;

public class havePackage : MonoBehaviour {

	public bool pckge = false;

	void Awake() {
		DontDestroyOnLoad (gameObject);
	}

	void Start () {
	
	}
	

	void Update () {
	
		print (pckge);

	}
}
