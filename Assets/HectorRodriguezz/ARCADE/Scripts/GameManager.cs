using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Hector
{
    public class GameManager : MonoBehaviour
    {

        public Fireball[] fireballs;

        public Cactus cactus;

        public Transform pellets;


        public TextMeshProUGUI gameOverText;
        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI livesText;



        public int fireballMultiplier { get; private set; } = 1;

        public int score { get; private set; }

        public int lives { get; private set; }

        private void Start()
        {
            NewGame();
        }

        private void Update()
        {
            if (this.lives <= 0 && Input.anyKeyDown)
            {
                NewGame();
            }

        }

        private void NewGame()
        {
            SetScore(0);
            SetLives(3);
            NewRound();
        }

        private void NewRound()
        {
            gameOverText.enabled = false;

            foreach (Transform pellet in this.pellets)
            {
                pellet.gameObject.SetActive(true);
            }

            ResetState();

        }

        private void ResetState()
        {


            for (int i = 0; i < this.fireballs.Length; i++)
            {


                fireballs[i].ResetState();
            }

            cactus.ResetState();
        }

        private void GameOver()
        {
            gameOverText.enabled = true;

            for (int i = 0; i < this.fireballs.Length; i++)
            {

                this.fireballs[i].gameObject.SetActive(false);
            }

            this.cactus.gameObject.SetActive(false);
        }



        private void SetLives(int lives)
        {
            this.lives = lives;
            livesText.text = "x" + lives.ToString();
        }

        private void SetScore(int score)
        {
            this.score = score;
            scoreText.text = score.ToString().PadLeft(2, '0');

        }

        public void CactusDeath()
        {
            cactus.DeathSequence();

            SetLives(this.lives - 1);

            if (this.lives > 0)
            {
                Invoke(nameof(ResetState), 3.0f);
            }
            else
            {
                GameOver();
            }
        }

        public void FireBallDeath(Fireball fireball)
        {
            int points = fireball.points * fireballMultiplier;
            SetScore(score + points);

            fireballMultiplier++;
        }



        public void DrinkPellet(Pellet pellet)
        {

            pellet.gameObject.SetActive(false);

            SetScore(this.score + pellet.points);

            if (!HasRemainingPellet())
            {
                this.cactus.gameObject.SetActive(false);
                Invoke(nameof(NewRound), 3.0f);
            }

        }

        public void DrinkPowerPellet(PowerPellet pellet)
        {
            for (int i = 0; i < fireballs.Length; i++)
            {
                fireballs[i].cool.Enable(pellet.duration);
            }
            DrinkPellet(pellet);
            CancelInvoke(nameof(ResetfireballMultiplier));
            Invoke(nameof(ResetfireballMultiplier), pellet.duration);

        }

        private bool HasRemainingPellet()
        {
            foreach (Transform pellet in this.pellets)
            {
                if (pellet.gameObject.activeSelf)
                {
                    return true;
                }
            }

            return false;
        }
        private void ResetfireballMultiplier()
        {
            this.fireballMultiplier = 1;
        }
    }
}