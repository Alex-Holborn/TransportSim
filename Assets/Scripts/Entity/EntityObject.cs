using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityObject : MonoBehaviour
{
    // Base class for object interaction, will control opening of infodisplays

    public virtual void OnMouseDown()
    {
        Debug.Log("Clicked");
    }
}
