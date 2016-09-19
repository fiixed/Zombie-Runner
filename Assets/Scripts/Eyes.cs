using UnityEngine;
using System.Collections;

public class Eyes : MonoBehaviour {

	private Camera eyes;
	private float defaultFOV;
	
	// Use this for initialization
	void Start () {
		eyes = GetComponent<Camera>();
		defaultFOV = eyes.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {
		// if (Input.GetKeyDown(KeyCode.V)) {
		// 	eyes.fieldOfView = defaultFOV / (float)1.5;
		// } 
		// if (Input.GetKeyUp(KeyCode.V)) {
		// 	eyes.fieldOfView = defaultFOV;
		// }

		if (Input.GetButton("Zoom")) {
			eyes.fieldOfView = defaultFOV / (float)1.5;
		} else {
			eyes.fieldOfView = defaultFOV;
		}
	}
}
