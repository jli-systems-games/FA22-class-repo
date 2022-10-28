using UnityEngine;

namespace HectorRodriguez
{

    public class PlayerManager : MonoBehaviour
    {

        private Transform player;
        private Vector3 startMousePos, startPlayerPos;
        private bool moveTheplayer, gameState;
        [Range(0f, 1f)] private float maxSpeed;
        [Range(0f, 1f)] private float camSpeed;
        [Range(0f, 5)] private float pathSpeed;
        private float velocity, camVelocity;
        private Camera mainCam;
        public Transform path;


        // Start is called before the first frame update
        void Start()
        {
            player = transform;
            mainCam = Camera.main;

        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetMouseButtonDown(0))
            {
                moveTheplayer = true;

                Plane newPlan = new Plane(Vector3.up, 0f);
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


                if (newPlan.Raycast(ray, out var distance))
                {
                    startMousePos = ray.GetPoint(distance);
                    startPlayerPos = player.position;

                }
            }

            else if (Input.GetMouseButtonUp(0))
            {
                moveTheplayer = false;
            }

            if (moveTheplayer)
            {
                Plane newPlan = new Plane(Vector3.up, 0f);
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (newPlan.Raycast(ray, out var distance))
                {
                    Vector3 mouseNewPos = ray.GetPoint(distance);
                    Vector3 MouseNewPos = mouseNewPos - startMousePos;
                    Vector3 DesirePlayerPos = MouseNewPos + startPlayerPos;

                    DesirePlayerPos.x = Mathf.Clamp(DesirePlayerPos.x, -1.5f, 1.5f);

                    player.position = new Vector3(Mathf.SmoothDamp(player.position.x, DesirePlayerPos.x, ref velocity, maxSpeed)
                     , player.position.y, player.position.x);

                }
            }

            var pathNewPos = path.position;
            path.position = new Vector3(pathNewPos.x, pathNewPos.y, Mathf.MoveTowards(pathNewPos.z, -1000f, pathSpeed * Time.deltaTime));


        }

        private void LateUpdate()
        {
            var CameraNewPos = mainCam.transform.position;

            mainCam.transform.position = new Vector3(Mathf.SmoothDamp(CameraNewPos.x, player.transform.position.x, ref camVelocity, camSpeed)
            , CameraNewPos.y, CameraNewPos.z);
        }
    }
}

