using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace HectorRodriguez
{
    public class Stacking : MonoBehaviour
    {
        private Rigidbody _playerRigidbody;
        private float _xMove;
        private float _zMove;
        private Vector3 _firstConchaPos;
        private Vector3 _currentConchaPos;


        public TextMeshProUGUI MyText;
        public float  Score = 0f;


        public AudioSource audioSource;
public float delay=4;
        //
        [SerializeField] private float _speed;
        //
        List<GameObject> _conchaList = new List<GameObject>();
        private int _conchaListIndexCounter = 0;



        private void Start()
        {
            MyText.text = "";
        }

        private void Awake()
        {
            _playerRigidbody = GetComponent<Rigidbody>();
        }

        void Update()
        {
            _xMove = Input.GetAxis("Horizontal");
            _zMove = Input.GetAxis("Vertical");
            Vector3 forwardMove = Vector3.forward * _zMove * _speed * Time.deltaTime;
            Vector3 horizontalMove = Vector3.right * _xMove * _speed * Time.deltaTime;
            _playerRigidbody.MovePosition(transform.position + forwardMove + horizontalMove);

            MyText.text = "Score:" + Score;
        }

        private void IncreaseScore()
        {
            Score++;
            audioSource.Play();
        }

        private void OnTriggerEnter(Collider collision)
        {
            if (collision.CompareTag("Concha"))
            {
                _conchaList.Add(collision.gameObject);
                if (_conchaList.Count == 1 )
                {
                    IncreaseScore();
                    _firstConchaPos = GetComponent<MeshRenderer>().bounds.max;
                    _currentConchaPos = new Vector3(collision.transform.position.x, _firstConchaPos.y, collision.transform.position.z);
                    collision.gameObject.transform.position = _currentConchaPos;
                    _currentConchaPos = new Vector3(collision.transform.position.x, transform.position.y + 0.3f, collision.transform.position.z);
                    collision.gameObject.GetComponent<Concha>().UpdateConchaPosition(transform, true);
                    
                }
                else if (_conchaList.Count > 1)
                {
                    IncreaseScore();
                    collision.gameObject.transform.position = _currentConchaPos;
                    _currentConchaPos = new Vector3(collision.transform.position.x, collision.gameObject.transform.position.y + 0.3f, collision.transform.position.z);
                    collision.gameObject.GetComponent<Concha>().UpdateConchaPosition(_conchaList[_conchaListIndexCounter].transform, true);
                    _conchaListIndexCounter++;
                    

                }
            }
        }
    }

}