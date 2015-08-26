using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour {
	public float ballSpeed = 500;
	bool inPlay = false;
	int randomInt;
	Rigidbody ballPhysics;
	void Awake () {
		ballPhysics = GetComponent<Rigidbody> ();
		randomInt = Random.Range (1, 3);
	}
	
	void FixedUpdate () {
		if (inPlay == false && Input.GetKeyDown (KeyCode.Space) == true) {
			ballPhysics.isKinematic = false;
			transform.parent = null;
			inPlay = true;
			if (randomInt == 1) {
				ballPhysics.AddForce(new Vector3(ballSpeed, ballSpeed, 0));
			} else if (randomInt == 2) {
				ballPhysics.AddForce(new Vector3(ballSpeed, -ballSpeed, 0));
			}
		}
	}


}
