using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {

	bool startofscene = true;
	public GameObject SpawnPoint1;
	public GameObject SpawnPoint2;
	public GameObject Player;

	void Start () {
	
	}

	void Update () {
	
		if (startofscene == true) {
			if (spawner.dir == true) {
				Instantiate (Player, SpawnPoint2.transform.position, new Quaternion (0, 0, 0, 0));
			}

			if (spawner.dir == false) {
				Instantiate (Player, SpawnPoint1.transform.position, new Quaternion (0, 0, 0, 0));
			}
			startofscene = false;
		}

	}

}
