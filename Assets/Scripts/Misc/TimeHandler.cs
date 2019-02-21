using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeHandler : MonoBehaviour
{
    
    public Date CurrentDate { get; private set; }
    
    // Start is called before the first frame update
    void Start()
    {
        CurrentDate = new Date();
        CurrentDate.SetDay(1);
        CurrentDate.SetMonth(6);
        CurrentDate.SetYear(1970);
    }

    void Update()
    {
        CurrentDate = Date.CreateTomorrow(CurrentDate);
        Debug.Log("Date: " + CurrentDate.Day+"/"+CurrentDate.Month+"/"+CurrentDate.Year);
    }

}
