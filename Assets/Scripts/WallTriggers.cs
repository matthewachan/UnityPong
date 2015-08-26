using UnityEngine;
using System.Collections;

public class WallTriggers : MonoBehaviour {
	AudioSource bounce;

	void Start () {
		bounce = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider obj) {
		if (obj.tag == "Ball") 
			bounce.Play ();
	}
}
