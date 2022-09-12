using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NickelVampireSurvive
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D _rb;
        public int playerId;
        [SerializeField] private float speed = 15f;
        // Start is called before the first frame update
        void Start()
        {
            _rb = transform.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            _rb.velocity = new Vector2(Input.GetAxis("HorizontalPlayer" + playerId), Input.GetAxis("VerticalPlayer" +playerId)) * speed;
        }
    }
}