using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : ScriptableObject
{
    
    public GameObject TruckObject { get; private set; }
    public TruckData TruckData { get; private set; }


    public Truck() { }

}
