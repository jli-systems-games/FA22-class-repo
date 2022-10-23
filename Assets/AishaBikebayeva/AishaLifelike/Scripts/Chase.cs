using UnityEngine;
using UnityEngine.AI;

namespace AishaBikebayeva.AishaLifelike.Scripts
{
    public class Chase : MonoBehaviour
    {

        public GameObject Player;
        NavMeshAgent agent;
        // Start is called before the first frame update
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            agent.SetDestination(Player.transform.position);
        }

    }
}