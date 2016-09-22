using UnityEngine;
using System.Collections;

public class RadioSystem : MonoBehaviour {

	public AudioClip initialHeliCall;
	public AudioClip initalCallReply;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}

	void OnMakeInitialHeliCall() {
		audioSource.clip = initialHeliCall;
		audioSource.Play();

		Invoke("InitialReply", initialHeliCall.length + 1f);
	}

	void InitialReply() {
		audioSource.clip = initalCallReply;
		audioSource.Play();
		BroadcastMessage("OnDispatchHelicopter");
	}
}
