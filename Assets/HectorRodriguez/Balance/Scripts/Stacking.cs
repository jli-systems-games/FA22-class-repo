using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HectorRodriguez
{
    public class Stacking : MonoBehaviour
    {
        private Rigidbody _playerRigidbody;
        private float _xMove;
        private float _zMove;
        private Vector3 _firstConchaPos;
        private Vector3 _currentConchaPos;
        //
        [SerializeField] private float _speed;
        //
        List<GameObject> _conchaList = new List<GameObject>();
        private int _conchaListIndexCounter = 0;

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
        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Concha"))
            {
                _conchaList.Add(other.gameObject);
                if (_conchaList.Count == 1)
                {
                    _firstConchaPos = GetComponent<MeshRenderer>().bounds.max;
                    _currentConchaPos = new Vector3(other.transform.position.x, _firstConchaPos.y, other.transform.position.z);
                    other.gameObject.transform.position = _currentConchaPos;
                    _currentConchaPos = new Vector3(other.transform.position.x, transform.position.y + 0.3f, other.transform.position.z);
                    other.gameObject.GetComponent<Concha>().UpdateConchaPosition(transform, true);

                }
                else if (_conchaList.Count > 1)
                {
                    other.gameObject.transform.position = _currentConchaPos;
                    _currentConchaPos = new Vector3(other.transform.position.x, other.gameObject.transform.position.y + 0.3f, other.transform.position.z);
                    other.gameObject.GetComponent<Concha>().UpdateConchaPosition(_conchaList[_conchaListIndexCounter].transform, true);
                    _conchaListIndexCounter++;
                }
            }
        }
    }

}