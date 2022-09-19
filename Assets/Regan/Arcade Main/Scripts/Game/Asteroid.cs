using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Regan {

[RequireComponent(typeof(Rigidbody)),RequireComponent(typeof(Obstacle))]
public class Asteroid : MonoBehaviour
{
    public float astroidStage = 2;
    [SerializeField]
    GameObject explosionPrefab;

    private void Start()
    {
        GameManager.instance.currentAstroidAmount++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "bullet") { return; }

        Damage();
    }


    private void Damage()
    {
        if (astroidStage > 0)
        {
            Split();
        }
        
        Destroy(gameObject);
        GameObject explosion = Instantiate(explosionPrefab, GameManager.instance.worldTranform);
        explosion.transform.position = transform.position;
        GameManager.instance.currentAstroidAmount--;
        GameManager.instance.AddScore();
    }

    private void Split()
    {
        GameObject[] asteroidPrefabs = GameManager.instance.astroidTypes;
        for (int i = 0; i < Random.Range(2,5); i++)
        {
            int randomId = Random.Range(0,asteroidPrefabs.Length-1);
            CreateAsteroid(asteroidPrefabs[randomId]);
        }

    }

    private void CreateAsteroid(GameObject prefab)
    {
        GameObject asteroid = Instantiate(prefab, GameManager.instance.worldTranform);
        asteroid.transform.position = transform.position;
        asteroid.transform.localScale = transform.localScale * (0.65f + Random.value * 0.25f);
        asteroid.GetComponent<Asteroid>().astroidStage = astroidStage - 1;
        asteroid.GetComponent<Rigidbody>().velocity = new Vector2((Random.value - 0.5f) * 3, (Random.value - 0.5f) * 3);
    }

    private void OnDestroy()
    {
        

    }

}
}
