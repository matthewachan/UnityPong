using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {
	public GameObject ballPrefab;
	int randomX, randomY;
	Rigidbody ball;

	void Start() {
		SpawnBall ();
	}
	void SpawnLocation() {
		randomX = Random.Range (-9, 10);
		randomY = Random.Range (-5, 6);
	}


	void Update() {
		if (Input.GetMouseButtonDown (0)) {
			SpawnBall();
		}

	}
	void SpawnBall() {
		SpawnLocation ();
		Instantiate (ballPrefab, new Vector3 (randomX, randomY, 0), Quaternion.identity);
	}

}
