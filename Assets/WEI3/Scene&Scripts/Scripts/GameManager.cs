using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

namespace Hell

{
	using System.Collections.Generic;		
	using UnityEngine.UI;					
	
	public class GameManager : MonoBehaviour
	{
		public float levelStartDelay = 2f;						
		public float turnDelay = 0.1f;							
		public int playerFoodPoints = 100;						
		public static GameManager instance = null;				
		[HideInInspector] public bool playersTurn = true;		
		
		
		private Text levelText;									
		private GameObject levelImage;							
		private BoardManager boardScript;						
		private int level = 1;									
		private List<Enemy> enemies;							
		private bool enemiesMoving;								
		private bool doingSetup = true;						
		
		
		
		void Awake()
		{
            if (instance == null)

                instance = this;

            else if (instance != this)

                Destroy(gameObject);	
			
			DontDestroyOnLoad(gameObject);
			
			enemies = new List<Enemy>();
			
			boardScript = GetComponent<BoardManager>();
			
			InitGame();
		}

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        static public void CallbackInitialization()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        static private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
        {
            instance.level++;
            instance.InitGame();
        }

		
		void InitGame()
		{
			doingSetup = true;
			
			levelImage = GameObject.Find("LevelImage");
			
			levelText = GameObject.Find("LevelText").GetComponent<Text>();
			
			levelText.text = "Stage " + level;
			
			levelImage.SetActive(true);
			
			Invoke("HideLevelImage", levelStartDelay);
			
			enemies.Clear();
			
			boardScript.SetupScene(level);
			
		}
		
		
		void HideLevelImage()
		{
			levelImage.SetActive(false);
			
			doingSetup = false;
		}
		
		void Update()
		{
			if(playersTurn || enemiesMoving || doingSetup)
				
				return;
			
			StartCoroutine (MoveEnemies ());
		}
		
		public void AddEnemyToList(Enemy script)
		{
			enemies.Add(script);
		}
		
		
		public void GameOver()
		{
			levelText.text = "After " + level + " stages, you'll never feel the light again.";
			
			levelImage.SetActive(true);
			
			enabled = false;
		}
		
		IEnumerator MoveEnemies()
		{
			enemiesMoving = true;
			
			yield return new WaitForSeconds(turnDelay);
			
			if (enemies.Count == 0) 
			{
				yield return new WaitForSeconds(turnDelay);
			}
			
			for (int i = 0; i < enemies.Count; i++)
			{
				enemies[i].MoveEnemy ();
				
				yield return new WaitForSeconds(enemies[i].moveTime);
			}
			playersTurn = true;
			
			enemiesMoving = false;
		}
	}
}

