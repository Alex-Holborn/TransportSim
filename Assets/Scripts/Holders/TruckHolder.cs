using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckHolder : Holder<Truck>
{
    public Truck CreateNewTruck()
    {
        return ScriptableObject.CreateInstance<Truck>();
    }
}
