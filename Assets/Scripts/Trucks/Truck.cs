using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : ScriptableObject
{

    public enum TruckModels
    {
        //TODO: change to more formal names
        LargeTruck, SmallTruck
    }
    
    public Truck(){}
    
    public GameController GameController { get; private set; }
    
    public TruckData TruckData { get; private set; }
    
    public TruckObject TruckObject { get; private set; }
    
    public TruckModels TruckModel { get; private set; }
    
    public string TruckName { get; private set; }

    private void Awake()
    {
        GameController = FindObjectOfType<GameController>();
    }
    
    public void SetTruckName(string _name)
    {
        TruckName = _name;
    }

    public void SetTruckObject(TruckObject o)
    {
        TruckObject = o;
    }
}
