using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ekaterina
{

    public class EnemyAudioController : MonoBehaviour
{
    public Transform listenerTransform;
    AudioSource audioSource;
    public float minDist=1;
    public float maxDist=400;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        float dist = Vector3.Distance(transform.position, listenerTransform.position);
 
        if(dist < minDist)
        {
            audioSource.volume = 0.5f;
        }
        else if(dist > maxDist)
        {
            audioSource.volume = 0;
        }
        else
        {
            audioSource.volume = 0.5f - ((dist - minDist) / (maxDist - minDist));
        }
    }
}
}

