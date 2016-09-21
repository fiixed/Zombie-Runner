using UnityEngine;
using System.Collections;

public class ClearArea : MonoBehaviour {

	public float timeSinceLastTrigger = 0f;

	void Update() {
		timeSinceLastTrigger += Time.deltaTime;
		if (timeSinceLastTrigger > 5f) {
			SendMessageUpwards("OnFindClearArea");
		}
	}
	
	void OnTriggerStay(Collider col) {
		timeSinceLastTrigger = 0f;
	}

	
}
