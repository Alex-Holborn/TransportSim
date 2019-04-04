using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{

    private Settings settings;

    private bool hasLoaded = false;
    
    void Start()
    {
        NewGameOptionsScreen o = FindObjectOfType<NewGameOptionsScreen>();
        settings = o.Settings;
        StartLoadWorld();
        StartCoroutine(skip());
    }

    IEnumerator WaitForLoad()
    {
        Debug.Log("Loading World Scene");
        DontDestroyOnLoad(CreateWorld(settings.WorldSize));
        DontDestroyOnLoad(CreateDepot(settings.DepotSize));
        yield return new WaitUntil(() => hasLoaded);
        Debug.Log("Loaded Scene");
        SceneManager.LoadScene(3);
    }

    IEnumerator skip()
    {
        Debug.Log("Skipping");
        yield return new WaitForSeconds(3f);
        hasLoaded = true;
    }
    
    private void StartLoadWorld()
    {
        StartCoroutine(WaitForLoad());
    }
    
    private GameObject CreateDepot(Settings.Size depotSize)
    {
        GameObject depot = new GameObject("Depot");
        return depot;
    }

    private GameObject CreateWorld(Settings.Size worldSize)
    {
        GameObject floor = new GameObject("Floor");
        floor.transform.localScale = new Vector3(((int)worldSize +1) * 10, 1, ((int)worldSize + 1) * 10);
        return floor;
    }

    
    
}
