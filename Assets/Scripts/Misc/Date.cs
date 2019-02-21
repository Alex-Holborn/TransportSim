using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Date
{

    public static Date CreateTomorrow(Date today)
    {
        if (today.Day < today.GetDaysInMonth(today.Month) || (today.Month == 2 && IsLeapYear(today.Year) && today.Day < 29))
        {
            //If today's number is less than total days in month, just add a day
            Date d = new Date();
            d.SetDay(today.Day + 1);
            d.SetMonth(today.Month);
            d.SetYear(today.Year);
            return d;
        }
        else
        {
            //Here we are at the end of a month
            Date d = new Date();
            d.SetDay(1);
            if (today.Month == 12)
            {
                //End of the year
                d.SetMonth(1);
                d.SetYear(today.Year + 1);
            }
            else
            {
                d.SetMonth(today.Month + 1);
                d.SetYear(today.Year);
            }

            return d;
        }
    }
    
    public static bool IsLeapYear(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }

                return false;
            }

            return true;
        }

        return false;
    }
    
    private string[] months = new string[12]
    {
        "January", "February", "March", "April", "May", "June", "July", "August", "September", "October",
        "November", "December"
    };
    
    private int[] daysInMonth = new int[12]
    {
        31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
    };
    
    public int Day { get; private set; }
    public int Month { get; private set; }
    public int Year { get; private set; }

    public Date(){}
    
    public void SetDay(int day)
    {
        Day = day;
    }

    public void SetMonth(int month)
    {
        Month = month;
    }

    public void SetYear(int year)
    {
        Year = year;
    }

    public string GetMonthName(int month)
    {
        return months[month - 1];
    }

    public int GetDaysInMonth(int month)
    {
        return daysInMonth[month - 1];
    }
    
}
