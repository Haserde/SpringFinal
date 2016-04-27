using UnityEngine;
using System.Collections;

public class screenTransition : MonoBehaviour {

	public float fadespd = 2.5f;
	bool scenestarting = true;
	public GUITexture fader;

	void Awake() {
		
		fader.pixelInset = new Rect (0f, 0f, Screen.width, Screen.height);

	}

	void start() {
		fader.color = Color.black;
		fader.pixelInset = new Rect (0f, 0f, Screen.width, Screen.height);
	}


	void update() {

		print (fader.color.a);

		if (scenestarting == true) {
			startscreen ();
		}
	}

	void fadetoclear() {
		fader.color = Color.Lerp (fader.color, Color.clear, fadespd * Time.deltaTime);
	}

	void fadetoblack() {
		fader.color = Color.Lerp (fader.color, Color.black, fadespd * Time.deltaTime);
	}

	void startscreen() {
		fadetoclear ();

		if (fader.color.a <= 0.05f) {
			fader.color = Color.clear;
			fader.enabled = false;
			scenestarting = false;
		}
	}

	void endscene() {
		fader.enabled = true;
		fadetoblack ();

		if (fader.color.a >= 0.95f) {
			Application.LoadLevel ("Testing");
		}
	}
}
