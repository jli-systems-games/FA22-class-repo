using UnityEngine;

namespace Nickel.NickelArcade.NickelScript
{
    public class PlayerReadyDetect : MonoBehaviour
    {
        // Start is called before the first frame update
        public int playerId;

        public static bool player1Ready = false;
        public static bool player2Ready = false;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player" + playerId))
            {

                if (playerId == 1)
                {
                    player1Ready = true;

                }
                else if (playerId == 2)
                {
                    player2Ready = true;
                }

            }
        }


    }
}

