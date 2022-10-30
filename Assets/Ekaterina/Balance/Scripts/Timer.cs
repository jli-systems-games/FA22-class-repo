using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Ekaterina {
public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countUp;

    [Header("Format Settings")]
    public bool hasFormat;
    public TimerFormats format;
    private Dictionary<TimerFormats, string> timeFormats = new Dictionary<TimerFormats, string>();
    
    void Start()
    {
        timeFormats.Add(TimerFormats.Primary, "00:00");
    }

    void Update()
    {
        currentTime = countUp ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        SetTimerText();
    }

    private void SetTimerText()
    {
        timerText.text = hasFormat ? currentTime.ToString(timeFormats[format]) : currentTime.ToString();
    }
}

public enum TimerFormats
{
    Primary
}
}
