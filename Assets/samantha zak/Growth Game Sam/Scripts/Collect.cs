using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Sam
{

	public class Collect : MonoBehaviour
	{

		private int leaf = 0;


		[SerializeField] private Text leafText;


		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.gameObject.CompareTag("Leaf"))
			{
				Destroy(collision.gameObject);
				leaf++;
				leafText.text = "Leaves collected: " + leaf;

			}

		}



	}
}