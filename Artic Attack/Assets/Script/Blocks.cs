using UnityEngine;
using System.Collections;

public class Blocks : MonoBehaviour {

	public int pos;
	float move;
	Vector3 posxy;

	void Start () {
	
		posxy = gameObject.transform.position;
		move = gameObject.transform.localScale.y;

	}

	void Update () {
	
		if (pos == 1) {
			gameObject.transform.position = posxy + new Vector3 (0f, move, 0f);
		}

		if (pos == 2) {
			gameObject.transform.position = posxy;
		}

		if (pos == 3) {
			gameObject.transform.position = posxy + new Vector3 (0f, -move, 0f);
		}

		if (pos > 3) {
			pos = 1;
		}

		if (pos < 1) {
			pos = 3;
		}
	}

	public void PosNumber(int num){

		pos = pos + num;
	}
}
