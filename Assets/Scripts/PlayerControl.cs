using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	// Make the paddle's movement controllable
	public float moveSpeed = 1;
	float yPos;
	AudioSource bounce;

	void Start () {
		bounce = GetComponent<AudioSource> ();
		transform.position = new Vector3 (-8, 0, 1);
	}

	void OnTriggerEnter(Collider obj) {
		if (obj.tag == "Ball")
			bounce.Play ();
	}
	void Update () {
		// The user's input controls the vertical position of the paddle
		yPos = transform.position.y + (Input.GetAxis ("Vertical") * moveSpeed);
		// Sets the bounds on how far up the paddle can travel
		transform.position = new Vector3 (-8, Mathf.Clamp (yPos, -4, 4), 1);

	}

}
