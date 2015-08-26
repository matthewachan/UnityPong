using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {
	GameObject ball;
	public float moveSpeed = 5;
	float yPos;
	AudioSource bounce;
	void Start() {
		bounce = GetComponent<AudioSource> ();
	}
	void Update () {
		// Find the ball
		ball = GameObject.FindGameObjectWithTag ("Ball");
		// Set the location for the paddle to move, depending on where the ball is
		yPos = Mathf.Lerp (transform.position.y, ball.gameObject.transform.position.y, Time.deltaTime * moveSpeed);
		// Move the paddle
		transform.position = new Vector3(8, Mathf.Clamp(yPos, -4, 4), 1);
	}
	void OnTriggerEnter(Collider obj) {
		if (obj.tag == "Ball") 
			bounce.Play ();
	}

}
