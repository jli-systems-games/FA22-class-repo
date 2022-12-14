using UnityEngine;
using UnityEngine.SceneManagement;

namespace ReganLifeLike
{
    public class Player : MonoBehaviour
    {
        public int health = 100;

        public int fleshAmount = 0;
        public int maxFlesh = 10;

        [SerializeField]
        private SpriteRenderer _spriteRenderer;
        [SerializeField]
        private PlayerMovementController _playerMovementController;
        [SerializeField]
        private PlayerWeaponController _playerWeaponController;
        [SerializeField]
        private AudioSource _damageSound;

        private void Update()
        {
            _spriteRenderer.material.color = new Color((float)fleshAmount / (maxFlesh * 1.75f), 0, 0);
        }

        public void Damage(int amount)
        {
            health -= amount;

            _damageSound.Play();

            if (health < 0)
            {
                SceneManager.LoadScene("Regan.LifeLike.Main");
            }
        }

        public void CollectFlesh(int amount)
        {
            if (fleshAmount < maxFlesh)
                fleshAmount += amount;
        }

        public void EndGame()
        {
            _playerMovementController.active = false;
            _playerWeaponController.active = false;
        }

    }
}