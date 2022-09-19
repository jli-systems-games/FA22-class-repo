using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SpaceShipController : MonoBehaviour
{
    [SerializeField]
    float thrust = 100;
    [SerializeField]
    float torque = 100;
    [SerializeField]
    float bulletRecoil = 10;
    [SerializeField]
    float respawnGracePeriod = 3;
    [SerializeField]
    ParticleSystem engineParticles;
    [SerializeField]
    ParticleSystem smokeParticles;
    [SerializeField]
    MeshRenderer mainRenderer;

    [SerializeField]
    GameObject explosionPrefab;
    [SerializeField]
    GameObject bulletPrefab;

    bool grace = true;
    Rigidbody _rigidbody;
    float blinkTimeLeft = 0.5f;
    [SerializeField]
    float blinkPeriod = 0.1f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        GameManager.instance.player = this;
        StartCoroutine(RespawnGrace());
    }

    private void Update()
    {
        HandleInput();
        SpawnBlink();
    }

    private void HandleInput()
    {
        Vector2 inputVector = new Vector2();

        var emission = engineParticles.emission;
        var smokeEmission = smokeParticles.emission;
        emission.enabled = false;
        smokeEmission.enabled = false;

        if (Input.GetKey(KeyCode.W))
        {
            emission.enabled = true;
            smokeEmission.enabled = true;
            inputVector.y += 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x += 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x -= 1;
        }
     
        _rigidbody.AddRelativeForce( inputVector.y * Vector3.up * Time.deltaTime * thrust);
        _rigidbody.AddTorque(inputVector.x * -Vector3.forward * Time.deltaTime * torque);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, GameManager.instance.worldTranform);

        bullet.transform.position = transform.position + transform.up * 2;
        bullet.GetComponent<Bullet>().initialVelocity = transform.up * 20;

        _rigidbody.AddRelativeForce(Vector3.down * bulletRecoil);
    }

    private void SpawnBlink()
    {
        if (blinkTimeLeft <= 0)
        {
            blinkTimeLeft = blinkPeriod;

            mainRenderer.enabled = !(mainRenderer.enabled && grace);
        }
        blinkTimeLeft -= Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (grace) { return; }

        if (collision.collider.tag != "asteroid") { return; }
        GameManager.instance.PlayerDestroyed();
        
        GameObject explosion = Instantiate(explosionPrefab, GameManager.instance.worldTranform);
        explosion.transform.position = transform.position;

        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        

    }

    private IEnumerator RespawnGrace()
    {
        float time = respawnGracePeriod;
        mainRenderer.enabled = false;
        while (time > 0)
        {
            time -= Time.deltaTime;
            yield return null;
        }

        grace = false;
    }

}
