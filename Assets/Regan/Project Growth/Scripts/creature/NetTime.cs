using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

namespace Regan {

public class NetTime : MonoBehaviour
{
    public void getInternetTime(Action<string> onReceiveTime)
    {
        StartCoroutine(RequestInternetTime(onReceiveTime));
    }

    private IEnumerator RequestInternetTime(Action<string> onReceiveTime)
    {
        UnityWebRequest myHttpWebRequest = UnityWebRequest.Get("http://www.microsoft.com");
        yield return myHttpWebRequest.SendWebRequest();

        string netTime = myHttpWebRequest.GetResponseHeader("date");
        onReceiveTime(netTime);
    }
}
}
