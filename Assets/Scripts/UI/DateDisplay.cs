using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DateDisplay : MonoBehaviour
{

  private TimeController tc;
  private Text displayText;
  
  void Start()
  {
    if (tc == null)
    {
      tc = FindObjectOfType<TimeController>();
    }

    displayText = GetComponentInChildren<Text>();
    tc.onDayStart += UpdateDateDisplay;
  }

  private void UpdateDateDisplay()
  {
    displayText.text = tc.GetDateDisplayString();
  }
    
}
