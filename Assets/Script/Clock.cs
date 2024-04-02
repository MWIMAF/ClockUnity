using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondToDegrees = -6f;
    [SerializeField]
    Transform hoursPivot, MinutesPivot, secondPivot;
       
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation =
            Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
        MinutesPivot.localRotation =
            Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
        secondPivot.localRotation =
            Quaternion.Euler(0f, 0f, secondToDegrees * (float)time.TotalSeconds);
    }
}
