using UnityEngine;

namespace NickelVampireSurvive
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D _rb;
        [SerializeField] private float speed = 5f;
        // Start is called before the first frame update
        void Start()
        {
            _rb = transform.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            _rb.velocity = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0)*speed;
        }
    }
}
    


