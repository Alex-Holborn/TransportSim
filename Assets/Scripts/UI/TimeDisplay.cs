using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    private TimeController tc;
    private Text displayText;
  
    void Start()
    {
        if (tc == null)
        {
            tc = FindObjectOfType<TimeController>();
        }

        tc.onTimeChange += UpdateTimeDisplay;
        displayText = GetComponentInChildren<Text>();
    }

    private void UpdateTimeDisplay()
    {
        int[] t = tc.GetCurrentTime();
        string time = String.Format("{0:00}:{1:00}", t[0], t[1]);
        displayText.text = time;
    }
}
