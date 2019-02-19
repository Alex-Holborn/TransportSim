using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoWindow : UIComponent
{
    
    public Entity Object { get; private set; }
    
    public void setEntityObject(Entity e)
    {
        Object = e;
    }
    
}
