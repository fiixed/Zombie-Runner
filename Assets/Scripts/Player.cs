using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Transform playerSpawnPoints;
	private bool reSpawn = false;
	public Helicopter helicopter;

	private bool lastToggle = false;
	private Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
		
	}

	void Update() {
		if (lastToggle != reSpawn) {
			ReSpawn();
			reSpawn = false;
		} else {
			lastToggle = reSpawn;
		}
	}
	
	private void ReSpawn() {
		Transform sp = spawnPoints[Random.Range(1, spawnPoints.Length)];
		transform.position = sp.transform.position;

	}

	void OnFindClearArea() {
		Debug.Log("found clear area in player");
		helicopter.Call();
	}
}
