using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {

	public AudioClip callSound;

	public bool called = false;
	private AudioSource audioSource;

	private Rigidbody rb;
	
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		rb = GetComponent<Rigidbody>();
	}
	
	public void Call() {
		if (!called) {
			Debug.Log("heli called");
			called = true;
			audioSource.clip = callSound;
			audioSource.Play();
			rb.velocity = new Vector3(0,0, 50f);
		}	
	}
}
