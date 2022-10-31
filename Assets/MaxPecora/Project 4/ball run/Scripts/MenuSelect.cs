using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace max
{

	public class MenuSelect : MonoBehaviour
	{

		public GameObject mainUI;
		public GameObject gameUI;
		public GameObject pauseMenu;
		public GameObject gameOverMenu;

		private AudioSource buttonClick;

		void Start()
		{
			buttonClick = GameObject.Find("buttonClick").GetComponent<AudioSource>();
		}
		public void play()
		{
			buttonClick.Play();
			Time.timeScale = 1;
			mainUI.SetActive(false);
			gameUI.SetActive(true);
			GameObject.Find("ball").GetComponent<PlayerMovement>().enabled = true;
			GameObject.Find("Canvas").GetComponent<SpawnObstacles>().enabled = true;
		}
		public void resume()
		{
			buttonClick.Play();
			Time.timeScale = 1;
			pauseMenu.SetActive(false);

		}
		public void pause()
		{
			buttonClick.Play();
			Time.timeScale = 0;
			pauseMenu.SetActive(true);
		}
		public void restart()
		{
			buttonClick.Play();
			GameObject[] boxes = GameObject.FindGameObjectsWithTag("box");
			for (int i = 0; i < boxes.Length; i++)
			{
				Destroy(boxes[i]);
			}
			GameObject ball = GameObject.Find("ball");
			ball.transform.position = new Vector2(-0.5f, -3.12f);
			ball.transform.rotation = Quaternion.Euler(0, 0, 0);
			ball.GetComponent<PlayerMovement>().score = 0;
			ball.GetComponent<PlayerMovement>().timer = 0;
			ball.GetComponent<PlayerMovement>().move = false;
			ball.GetComponent<PlayerMovement>().enabled = true;

			SpawnObstacles spawnObstacles = GameObject.Find("Canvas").GetComponent<SpawnObstacles>();
			spawnObstacles.timer = 0;
			spawnObstacles.level = 1;
			spawnObstacles.gravityScale = 0.3f;

			pauseMenu.SetActive(false);
			gameOverMenu.GetComponent<Transform>().localScale = new Vector2(0, 0);
			Time.timeScale = 1;
			GameObject.Find("score").GetComponent<Text>().text = "SCORE: 0";
			GameObject.Find("Canvas").GetComponent<SpawnObstacles>().enabled = true;
		}
		public void exit()
		{
			restart();
			GameObject.Find("Canvas").GetComponent<SpawnObstacles>().enabled = false;
			GameObject.Find("ball").GetComponent<PlayerMovement>().enabled = false;
			gameOverMenu.GetComponent<Transform>().localScale = new Vector2(0, 0);
			pauseMenu.SetActive(false);
			gameUI.SetActive(false);
			mainUI.SetActive(true);
		}
	}
}
