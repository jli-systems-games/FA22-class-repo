using UnityEngine;

namespace AishaBikebayeva.GrowthAisha.Scripts
{
    // public float petMoveTimer
    public class PetManager : MonoBehaviour
    {
        public PetController pet;
        public NeedsControl needscontrol;
        public static PetManager instance;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public static void Die()
        {
            Debug.Log("Pet Died");
        }
    }
}