using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace max
{

	public class DestroyFallingObject : MonoBehaviour
	{
		public GameObject explosion;

		void OnTriggerEnter2D(Collider2D col)
		{
			if (col.gameObject.name.Equals("ball"))
			{
				GameObject[] boxes = GameObject.FindGameObjectsWithTag("box");
				for (int i = 0; i < boxes.Length; i++)
				{
					Destroy(boxes[i]);
				}
				GameObject.Find("gameOverMenu").GetComponent<Transform>().localScale = new Vector2(1, 1);
				GameObject.Find("Canvas").GetComponent<SpawnObstacles>().enabled = false;
				GameObject.Find("ball").GetComponent<PlayerMovement>().enabled = false;
				GameObject.Find("gameOver").GetComponent<AudioSource>().Play();
			}
			else
			{
				Destroy(this.gameObject);
			}
		}
	}
}