using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace max
{

	public class SpawnObstacles : MonoBehaviour
	{

		public float timer = 0;
		public float level = 1f;
		public float gravityScale = 0.3f;

		void Update()
		{
			timer += Time.deltaTime;
			if (timer >= level)
			{
				if (level > 0.25f)
				{
					level -= 0.02f;
				}
				timer = 0;
				int posX = Random.Range(-8, 8);
				GameObject g = Instantiate(Resources.Load("box"), new Vector3(posX, 6, 0), Quaternion.identity) as GameObject;
				g.GetComponent<Rigidbody2D>().gravityScale = gravityScale;
				gravityScale += 0.005f;
			}
		}
	}
}
