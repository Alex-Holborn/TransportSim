using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolderManager : MonoBehaviour
{

    private GameObject truckObjectHolder; //Empty game object for holding all trucks
    private GameObject cityObjectHolder;
    
    
    public Settings Settings { get; private set; }
    public TruckHolder TruckHolder { get; private set; }
    public CityHolder CityHolder { get; private set; }

    void Start()
    {
        GameObject worldObjects = new GameObject("WorldObjects");
        truckObjectHolder = new GameObject("TruckObjects");
        truckObjectHolder.transform.SetParent(worldObjects.transform);
        cityObjectHolder = new GameObject("CityObjects");
        cityObjectHolder.transform.SetParent(worldObjects.transform);
        //Each Holder will load prefabs individually for instantiation later 
        if (TruckHolder == null)
        {
            TruckHolder = ScriptableObject.CreateInstance<TruckHolder>();
        }

        if (CityHolder == null)
        {
            CityHolder = ScriptableObject.CreateInstance<CityHolder>();
        }

        if (Settings == null)
        {
            Settings = FindObjectOfType<GameController>().Settings;
        }
    }

    public void CreateTruck(int modelIndex)
    {
        //A public wrapper for use in the debug button, do not use wrapper for in game purposes
        TruckHolder.CreateTruck(truckObjectHolder, modelIndex);
    }
   
    
}
