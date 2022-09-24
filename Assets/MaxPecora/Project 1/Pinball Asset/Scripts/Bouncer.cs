using UnityEngine;

namespace MaxArcade
{

    public class Bouncer : MonoBehaviour
    {
        [SerializeField]
        private Animation hitAnim;

        [SerializeField]
        private SoundManager soundManager;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Ball")
            {
                soundManager.BouncerHit();
                hitAnim.Play();
            }
        }
    }
}
