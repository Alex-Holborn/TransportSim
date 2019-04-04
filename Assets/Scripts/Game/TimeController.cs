using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    private List<Date> pastDates;
    
    public Date Today { get; private set; }

    private float SecsInDay = 20f; //Real world seconds in a game day, if running continuous this is the duration of a full day
    //Else it will be the duration of one shift, ie 8 hours
    
    private bool isContinuousTime = true;
    private bool canEndDay = false; //prevents an endday being called before set up is complete
    
    private float dayStartTime;

    public delegate void OnDayStart();

    public OnDayStart onDayStart;

    public delegate void OnDayEnd();

    public OnDayEnd onDayEnd;

    public delegate void OnTimeChange();

    public OnTimeChange onTimeChange;

    void Start()
    {
        if (pastDates == null)
        {
            pastDates = new List<Date>();
        }
        Today = CreateStartDay();     
        onDayEnd += ArchiveDay;
        SetDayStartTime();
        onDayStart += SetDayStartTime;
        canEndDay = true;
    }
    
    void Update()
    {
        if (onTimeChange != null)
        {
            onTimeChange();
        }
        if (Time.time - dayStartTime >= SecsInDay && canEndDay)
        {
            EndDay();
        }
    }

    private Date CreateStartDay()
    {
        //For now we just start on 1/1/1970
        Date d = new Date();
        d.SetDay(1);
        d.SetMonth(1);
        d.SetYear(1970);
        return d;
    }
    
    private void EndDay()
    {
        if (onDayEnd != null)
        {
            Debug.Log("onDayEndCalled");
            onDayEnd();
            MoveToNextDay();
        }
    }

    private void ArchiveDay()
    {
        pastDates.Add(Today);
    }
    
    private Date PrepareTomorrow()
    {
        return Date.CreateTomorrow(Today);
    }

    private void MoveToNextDay()
    {
        Today = PrepareTomorrow();
        if (onDayStart != null)
        {
            onDayStart();
        }
    }

    private void SetDayStartTime()
    {
        dayStartTime = Time.time;
    }

    public string GetDateDisplayString()
    {
        return String.Format("{0:00}/{1:00}/{2}", Today.Day, Today.Month, Today.Year);
    }

    public int[] GetCurrentTime()
    {
        int[] time = new int[2];
        time[0] = getCurrentHour();
        time[1] = getCurrentMinute();
        return time;
    }

    private int getCurrentHour()
    {
        return (int) getRawTime();
    }

    private int getCurrentMinute()
    {
        return (int) ((getRawTime() - getCurrentHour()) * 60);
    }

    private float getRawTime()
    {
        float secsPerHour;
        if (isContinuousTime)
        {
            secsPerHour = SecsInDay / 24;
        }
        else
        {
            secsPerHour = SecsInDay / 8;
        }

        return ((Time.time - dayStartTime) / secsPerHour);
    }
}
