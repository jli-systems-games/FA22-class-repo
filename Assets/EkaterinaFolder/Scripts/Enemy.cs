using UnityEngine;

namespace EkaterinaVampireSurvivors
{

    public class Enemy : MonoBehaviour
    {
        private Rigidbody2D _rb;

        public Transform Player;
        [SerializeField] private float speed = 10f;
        // Start is called before the first frame update

        void Start()
        {
            _rb = transform.GetComponent<Rigidbody2D>();

        }


        // Update is called once per frame
        void Update()
        {
            Vector2 direction = Vector2.MoveTowards(transform.position, Player.position, speed);
            direction -= (Vector2)transform.position;
            _rb.velocity = direction;


            Vector2.MoveTowards(transform.position, Player.position, speed);
            direction -= (Vector2)transform.position;
            _rb.velocity = direction;

        }
    }

}




