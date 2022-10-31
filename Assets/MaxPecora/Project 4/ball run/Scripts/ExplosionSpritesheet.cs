using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSpritesheet : MonoBehaviour {

	public SpriteRenderer sr;
	public Sprite[] images;
	private int counter = 0;
	private float timer = 0;

	void Update () {
		timer += Time.deltaTime;
		if (timer >= 0.02f) {
			timer = 0;
			counter++;
			sr.sprite = images [counter];
			if (counter == images.Length - 1) {
				Destroy (this.gameObject);
			}
		}
	}
}
