using UnityEngine;
using System.Collections;

public class NewGame : MonoBehaviour {

	void OnMouseDown() {
		transform.localScale *= 0.9f;
	}

	void OnMouseUp() {
		transform.localScale *= 1.1f;
		Application.LoadLevel (1);
	}
}
