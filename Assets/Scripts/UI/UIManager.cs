using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] private GameObject DebugMenuPrefab;
    private GameObject DebugMenu;

    public void ToggleDebugMenu()
    {
        if (DebugMenu == null)
        {
            DebugMenu = Instantiate(DebugMenuPrefab, GameObject.FindWithTag("Canvas").transform);
        }
        else if(DebugMenu.activeSelf)
        {
            DebugMenu.SetActive(false);
        }
        else
        {
            DebugMenu.SetActive(true);
        }
    }
}
