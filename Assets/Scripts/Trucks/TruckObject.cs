using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckObject : SelectableObject
{
    //This will hold the gameObject, and allow for interaction through OnMouseDown etc...
    
    public GameObject TruckGameObject { get; private set; }

    public Truck Truck { get; private set; }
    
    void Start()
    {
        if (TruckGameObject == null)
        {
            TruckGameObject = gameObject;
        }
    }

    public void SetTruck(Truck t)
    {
        Truck = t;
    }
    
    public override void OnMouseDown()
    {
        base.OnMouseDown();
        Truck.GameController.SetSelectedObject(this.TruckGameObject.GetComponent<SelectableObject>());
        Debug.Log("Clicked2");
    }
}
