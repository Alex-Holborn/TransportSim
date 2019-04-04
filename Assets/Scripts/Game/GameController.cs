using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    public Settings Settings { get; private set; }
    public SelectableObject SelectedObject { get; private set; }

    [SerializeField] private GameObject SmallInfoDisplay;
    
    public GameObject OpenSmallInfoDisplay { get; private set; }


    private void Awake()
    {
        if (Settings == null)
        {
            Settings = FindObjectOfType<Settings>();
            if (Settings == null)
            {
                Debug.Log("No settings found");
                Settings = ScriptableObject.CreateInstance<Settings>();
            }
        }
    }

    public void SetSelectedObject(SelectableObject o)
    {
        SelectedObject = o;
    }
}
