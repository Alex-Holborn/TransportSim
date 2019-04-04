using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : ScriptableObject
{
    public enum Size
    {
        xSmall,
        Small,
        Medium,
        Large,
        xLarge
    };
    
    public Size WorldSize { get; private set; }
    
    public Size DepotSize { get; private set; }

    public void SetWorldSize(Size size)
    {
        WorldSize = size;
    }

    public void SetDepotSize(Size size)
    {
        DepotSize = size;
    }
}
