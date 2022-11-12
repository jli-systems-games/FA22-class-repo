using UnityEngine;

namespace AishaBikebayeva.GrowthAisha.Scripts{

    public class TimingManager : MonoBehaviour
    {
        public static float gameHourTimer;
        public float hourLength;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        private void Update()
        {
            if(gameHourTimer <=0)
            {
                gameHourTimer = hourLength;
            }
            else
            {
                gameHourTimer -= Time.deltaTime;
            }
        }
    }
}