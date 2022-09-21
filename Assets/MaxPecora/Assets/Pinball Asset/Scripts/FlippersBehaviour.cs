using UnityEngine;

namespace MaxArcade
{

    public class FlippersBehaviour : MonoBehaviour
    {

        [SerializeField]
        private float tourque;

        private float width;

        [SerializeField]
        private Rigidbody2D leftFlipperRigidbody;
        [SerializeField]
        private Rigidbody2D rightFlipperRigidbody;


        // Use this for initialization
        void Awake()
        {
            width = Screen.width / 2.0f;
        }

        // Update is called once per frame
        private void Update()
        {

            #region UNITY_EDITOR

#if UNITY_EDITOR

        /* On Mouse Down */
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;

            /* RIGHT Flip detect */
            if (mousePosition.x >= width)
            {
                Flip(rightFlipperRigidbody, -tourque);
            }

            /* LEFT Flip detect */
            if (mousePosition.x < width)
            {
                Flip(leftFlipperRigidbody, tourque);

            }
        } /* On Mouse Hold */
        else if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseInput = Input.mousePosition;

            /* RIGHT Flip detect */
            if (mouseInput.x >= width)
            {
                Flip(rightFlipperRigidbody, -tourque);
            }

            /* LEFT Flip detect */
            if (mouseInput.x < width)
            {
                Flip(leftFlipperRigidbody, tourque);

            }
        }
#endif
            #endregion

            #region TOUCH

#if !UNITY_EDITOR
            if (Input.touchCount > 0)
            {
                for (int i = 0; i < Input.touchCount; i++)
                {
                    Touch touch = Input.GetTouch(i);

                    /* RIGHT Flip detect */
                    if (touch.position.x >= width)
                    {
                        Flip(rightFlipperRigidbody, -tourque);
                    }

                    /* LEFT Flip detect */
                    if (touch.position.x < width)
                    {
                        Flip(leftFlipperRigidbody, tourque);
                    }
                }
            }

#endif
            #endregion

        }

        private void Flip(Rigidbody2D rigidbody, float force)
        {
            rigidbody.AddTorque(force);
        }
    }
}
