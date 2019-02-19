using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityObject : MonoBehaviour
{
    
    public Entity Entity { get; private set; }
    private UIManager manager;

    public void SetEntity(Entity e)
    {
        Entity = e;
    }
    
    private void OnMouseDown()
    {
        if (manager == null)
        {
            manager = FindObjectOfType<UIManager>();
        }
        manager.DisplayInfoWindow(Entity);
    }
}
