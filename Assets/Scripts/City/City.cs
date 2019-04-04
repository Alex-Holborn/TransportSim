using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class City : ScriptableObject
{
      
    public string CityName { get; private set; }

    private readonly string[] _namePrefixes = new[] {"Brown", "Golden", "Autumn", "Palm", "Oak", "Green", "Meadow", "New"};
    private readonly string[] _nameSuffixes = new[] {" Hills", " Valley", " Springs", " Creek", "ville", "town", " River"};

    private String CreateCityName()
    {
        return _namePrefixes[Random.Range(0, _namePrefixes.Length)] + _nameSuffixes[Random.Range(0, _nameSuffixes.Length)];
    }

    public void SetRandomCityName()
    {
        CityName = CreateCityName();
    }
}
