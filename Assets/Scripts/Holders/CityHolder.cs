using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityHolder : Holder<City>
{
    public City CreateCity()
    {
        City c = ScriptableObject.CreateInstance<City>();
        c.SetRandomCityName();
        if (AddItem(c))
        {
            return c;
        }

        return null;
    }
}
