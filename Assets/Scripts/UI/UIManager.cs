using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public InfoWindow OpenInfoWindow { get; private set; }

    public void DisplayInfoWindow(Entity e)
    {
        if (OpenInfoWindow != null)
        {
            if (!OpenInfoWindow.Object.Equals(e))
            {
                Destroy(OpenInfoWindow);
                OpenInfoWindow = ScriptableObject.CreateInstance<InfoWindow>();
                OpenInfoWindow.setEntityObject(e);
            }
        }else
        {
            OpenInfoWindow = ScriptableObject.CreateInstance<InfoWindow>();
            OpenInfoWindow.setEntityObject(e);
        }
    }

}
