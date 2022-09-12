using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        
    }

    public delegate void NextRoundDelegate();
    public static event NextRoundDelegate OnNextRound;


    [SerializeField]
    private GameObject playerPrefab;
    [SerializeField]
    private float respawnCooldown = 2;


    public Vector2 worldBounds;
    
    public GameObject[] astroidTypes;
    [HideInInspector]
    public int currentAstroidAmount = 0;
    [HideInInspector]
    public SpaceShipController player;
    [HideInInspector]
    public int score = 0;

    private void Start()
    {
        respawnPlayer();
    }

    private void Update()
    {
        if (currentAstroidAmount > 0) { return; }
        NextRound();
    }

    private void NextRound()
    {
        OnNextRound?.Invoke();
    }

    public void AddScore()
    {
        score++;
    }

    public void PlayerDestroyed()
    {
        player = null;
        StartCoroutine(RespawnCooldown());
    }

    private IEnumerator RespawnCooldown()
    {
        float time = respawnCooldown;

        while (time > 0)
        {
            time -= Time.deltaTime;
            yield return null;
        }

        respawnPlayer();
    }

    private void respawnPlayer()
    {
        GameObject playerObject = Instantiate(playerPrefab, null);
        
        player = playerObject.GetComponent<SpaceShipController>();

    }
}
