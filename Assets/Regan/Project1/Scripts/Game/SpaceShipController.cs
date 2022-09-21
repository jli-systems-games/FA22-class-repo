using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Regan
{

    [RequireComponent(typeof(Rigidbody))]
    public class SpaceShipController : MonoBehaviour
    {
        [SerializeField] float thrust = 100;
        [SerializeField] float torque = 100;
        [SerializeField] float bulletRecoil = 10;
        [SerializeField] float respawnGracePeriod = 3;

        [SerializeField] GameObject bulletPrefab;

        bool grace = true;
        Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            GameManager.instance.player = this;
            StartCoroutine(RespawnGrace());
        }

        private void Update()
        {
            HandleInput();
        }

        private void HandleInput()
        {
            Vector2 inputVector = new Vector2();

            if (Input.GetKey(KeyCode.W))
            {
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

            _rigidbody.AddRelativeForce(inputVector.y * Vector3.up * Time.deltaTime * thrust);
            _rigidbody.AddTorque(inputVector.x * -Vector3.forward * Time.deltaTime * torque);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Shoot();
            }
        }

        private void Shoot()
        {
            GameObject bullet = Instantiate(bulletPrefab, null);

            bullet.transform.position = transform.position + transform.up * 2;
            bullet.GetComponent<Bullet>().initialVelocity = transform.up * 20;

            _rigidbody.AddRelativeForce(Vector3.down * bulletRecoil);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (grace)
            {
                return;
            }

            if (collision.collider.tag != "asteroid")
            {
                return;
            }

            GameManager.instance.PlayerDestroyed();
            Destroy(gameObject);
        }

        private void OnDestroy()
        {


        }

        private IEnumerator RespawnGrace()
        {
            float time = respawnGracePeriod;

            while (time > 0)
            {
                time -= Time.deltaTime;
                yield return null;
            }

            grace = false;
        }

    }
}
