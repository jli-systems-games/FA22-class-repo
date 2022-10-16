using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TextFx;
using UnityEngine.SceneManagement;

namespace AishaLifelike
{
    public class TextManager : MonoBehaviour
    {
        public TextFxUGUI textFX;
        // Start is called before the first frame update
        void Start()
        {
            textFX.AnimationManager.PlayAnimation();

            StartCoroutine(Delay());
        }

        private IEnumerator Delay()
        {
            yield return new WaitForSeconds(3);
            NewText("Hello? We lost you", 2);
            yield return new WaitForSeconds(3);
            NewText("Are you alive?", 2);
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene("Mars");
            yield return null;
        }

        private void StopAnimation()
        {
            textFX.AnimationManager.ResetAnimation();
            textFX.text = "";
        }

        private void NewText(string dialogue, float speed)
        {
            textFX.AnimationManager.ResetAnimation();
            textFX.text = dialogue;
            textFX.AnimationManager.PlayAnimation();
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}