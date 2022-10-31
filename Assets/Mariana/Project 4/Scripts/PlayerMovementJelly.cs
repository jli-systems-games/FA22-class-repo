using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mariana
{
public class PlayerMovementJelly : MonoBehaviour
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
            _rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;
        }
    }
}