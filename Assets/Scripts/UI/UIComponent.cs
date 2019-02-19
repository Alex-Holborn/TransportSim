using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIComponent : ScriptableObject
{
    public Canvas Canvas { get; private set; }

    void Awake()
    {
        if (Canvas == null)
        {
            Canvas = FindObjectOfType<Canvas>();
        }
    }
}
