using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugMenu : MonoBehaviour
{
    
    private HolderManager HolderManager;
    // Start is called before the first frame update
    void Start()
    {
        if (HolderManager == null)
        {
            HolderManager = FindObjectOfType<HolderManager>();
        }
    }

    public void AddTruck(int index)
    {
        HolderManager.CreateTruck(index);
    }
}
