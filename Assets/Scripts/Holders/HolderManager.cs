using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolderManager : MonoBehaviour
{

    public TruckHolder TruckHolder { get; private set; }

    void Start()
    {
        TruckHolder = ScriptableObject.CreateInstance<TruckHolder>();
    }

}
