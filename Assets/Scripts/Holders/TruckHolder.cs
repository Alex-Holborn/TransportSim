using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckHolder : Holder<Truck>
{
    
    private GameObject[] truckPrefabs;

    public Truck CreateTruck(GameObject truckHolder, int modelIndex)
    {
        //We accept an int so buttons in debug menu can call directly
        //TODO: Change to accepting T.TM 
        Truck.TruckModels model = (Truck.TruckModels)modelIndex;
        GameObject g = CreateTruckObject(truckHolder, model);
        g.name = model.ToString();
        Truck t = ScriptableObject.CreateInstance<Truck>();
        t.SetTruckName(model.ToString());
        TruckObject o = g.AddComponent<TruckObject>();
        o.SetTruck(t);
        if (AddItem(t))
        {
            Debug.Log(t.TruckName + " Added Successfully");
        }
        return t;
    }
    
    private GameObject CreateTruckObject(GameObject truckHolder, Truck.TruckModels model)
    {
        foreach(GameObject g in truckPrefabs)
        {
            if (g.name == model.ToString())
            {
                return Instantiate(g, truckHolder.transform);
            }    
        }
        return new GameObject("No Truck Found");
    }
    
    void Awake()
    {
        if (truckPrefabs == null)
        {
            Object[] truckObjs = Resources.LoadAll("Trucks");
            truckPrefabs = new GameObject[truckObjs.Length];
            for (int i = 0; i < truckPrefabs.Length; i++)
            {
                truckPrefabs[i] = truckObjs[i] as GameObject;
            }
            Debug.Log(truckPrefabs.Length + " truck prefabs loaded");
        }
    }
    
}
