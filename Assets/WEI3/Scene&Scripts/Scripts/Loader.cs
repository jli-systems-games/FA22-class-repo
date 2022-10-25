using UnityEngine;
using System.Collections;

namespace Hell

{	
	public class Loader : MonoBehaviour 
	{
		public GameObject gameManager;			
		public GameObject soundManager;			
		
		
		void Awake ()
		{
			if (GameManager.instance == null)
				
				Instantiate(gameManager);
			
			if (SoundManager.instance == null)
				
				Instantiate(soundManager);
		}
	}
}