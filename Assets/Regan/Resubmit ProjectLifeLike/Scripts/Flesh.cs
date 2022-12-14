using UnityEngine;

namespace ReganLifeLike
{
    public class Flesh : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer != 26) return;

            Player player = collision.GetComponent<Player>();

            player.CollectFlesh(1);

            Destroy(gameObject);
        }
    }

}
