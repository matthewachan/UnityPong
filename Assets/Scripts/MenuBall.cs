using UnityEngine;
using System.Collections;

public class MenuBall : MonoBehaviour {
	public float ballSpeed = 1000;
	Rigidbody rb;
	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> ();
		rb.AddForce (new Vector3 (ballSpeed, ballSpeed, 0));
	}
}
