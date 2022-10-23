using UnityEngine;
using UnityEngine.AI;

namespace AishaBikebayeva.AishaLifelike.Scripts
{
    public class Enemy : MonoBehaviour
    {
        public int health;
        public float speed;

        protected NavMeshAgent agent;
        // protected Animator anim;
        protected Player player;


        protected void SetUp() //protected means only child class can use it i.e the boss
        {
            agent = GetComponent<NavMeshAgent>();
            // anim = GetComponent<Animator>();
            // player = Player.instance;
            player = GetComponent<Player>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void ChaseEnemy()
        {
            agent.SetDestination(player.transform.position);
        }
    }
}