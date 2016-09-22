using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {

	public bool called = false;

	private Rigidbody rb;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	void OnDispatchHelicopter() {
		Debug.Log("heli called");
		rb.velocity = new Vector3(0,0, 50f);
		called = true;
	}
}
