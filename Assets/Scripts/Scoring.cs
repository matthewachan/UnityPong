using UnityEngine;
using System.Collections;

public class Scoring : MonoBehaviour {
	public TextMesh scoreBoard;
	public GameObject newBall;
	public Transform paddlePos;
	int score;
	GameObject ball;

	void Update () {
		ball = GameObject.FindGameObjectWithTag ("Ball");
		scoreBoard.text = score.ToString();
	}

	void OnTriggerEnter(Collider obj) {
		if (obj.tag == "Ball") {
			score++;
			Destroy (ball);
			//GameObject clone = (Instantiate(newBall, new Vector3(paddlePos.position.x + 1, paddlePos.position.y, 1), Quaternion.identity) as GameObject);
			//clone.transform.parent = paddlePos;
			//clone.transform.localScale = new Vector3(1,1,1);
			var clone = (Instantiate(newBall, new Vector3(paddlePos.position.x + 1, paddlePos.position.y, 1), Quaternion.identity) as GameObject);

			clone.transform.parent = paddlePos;
			clone.transform.localScale = new Vector3(1f,1f,1f);
		}
	}
}
