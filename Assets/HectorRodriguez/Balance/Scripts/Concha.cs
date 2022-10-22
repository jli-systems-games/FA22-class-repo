using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HectorRodriguez
{

    public class Concha : MonoBehaviour
    {
        [SerializeField] private float followSpeed;

        public void UpdateConchaPosition(Transform followedConcha, bool isFollowStart)
        {
            StartCoroutine(StartFollowingToLastCubePosition(followedConcha , isFollowStart));
        }

        IEnumerator StartFollowingToLastCubePosition(Transform followedConcha, bool isFollowStart)
        {

            while (isFollowStart)
            {
                yield return new WaitForEndOfFrame();
                transform.position = new Vector3(Mathf.Lerp(transform.position.x, followedConcha.position.x, followSpeed * Time.deltaTime),
                    transform.position.y,
                    Mathf.Lerp(transform.position.z,followedConcha.position.z, followSpeed * Time.deltaTime));
            }
        }
    }
}