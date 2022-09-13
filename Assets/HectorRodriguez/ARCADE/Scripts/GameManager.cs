using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Fireball[] fireballs;

    public Cactus cactus;

    public Transform pellets;


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

            this.fireballs[i].gameObject.SetActive(true);
        }

        this.cactus.gameObject.SetActive(true);
    }

    private void GameOver()
    {
        for (int i = 0; i < this.fireballs.Length; i++)
        {

            this.fireballs[i].gameObject.SetActive(true);
        }

        this.cactus.gameObject.SetActive(false);
    }


    private void SetScore(int score)
    {
        this.score = score;
    }

    private void SetLives(int lives)
    {
        this.lives = lives;
    }

    public void FireBallDeath(Fireball fireball)
    {
        SetScore(this.score + fireball.points);
    }

    public void CactusDeath()
    {
        this.cactus.gameObject.SetActive(false);

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
}
    /*
    public void DrinkPellet(Pellet pellet)
    {
        pellet.gameObject.SetActive(false);

        SetScore(this.score + pellet.points);

        if(HasRemainingPellet())
        {

        }
    }

    public void PowerPellet(PowerPellet pellet)
    {
        DrinkPellet(pellet);
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
*/