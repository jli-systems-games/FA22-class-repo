using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

	public GameObject scoreUI;
	public GameObject bestScoreUI;

	private Text bestScoreText;
	private Text scoreText;
	private Rigidbody2D rb;

	public bool move = false;
	public float timer = 0;
	public int score = 0;
	void Start() {
		rb = GetComponent<Rigidbody2D> ();
		scoreText = scoreUI.GetComponent<Text> ();
		score = 0;

		bestScoreText = bestScoreUI.GetComponent<Text> ();
		bestScoreText.text = "BEST SCORE: " + PlayerPrefs.GetInt ("bestScore", 0);
		GetComponent<PlayerMovement> ().enabled = false;
	}
	void Update () {
		timer += Time.deltaTime;
		if (timer >= 1) {
			timer = 0;
			score++;
			scoreText.text = "SCORE: " + score;
			if (score > PlayerPrefs.GetInt ("bestScore", 0)) {
				PlayerPrefs.SetInt ("bestScore", score);
				bestScoreText.text = "BEST SCORE: " + score;
			}
		}
		if (Input.GetMouseButtonDown (0)) {
			move = true;
		}
		if (Input.GetMouseButtonUp (0)) {
			move = false;
		}
	}
	void FixedUpdate() {
		if (move) {
			if (Input.mousePosition.x < Screen.width / 2) {
				rb.position = new Vector2 (rb.position.x - 0.1f, rb.position.y);
				transform.Rotate (0, 0, transform.rotation.z + 10);
			} else {
				rb.position = new Vector2 (rb.position.x + 0.1f, rb.position.y);
				transform.Rotate (0, 0, transform.rotation.z - 10);
			}
		}
	}
}
