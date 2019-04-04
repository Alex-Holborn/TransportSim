using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewGameOptionsScreen : MonoBehaviour
{

    public Settings Settings { get; private set; }
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void SetupGame()
    {
        Settings = ScriptableObject.CreateInstance<Settings>();
        //Here we can set the settings before passing over to loading scene to load it all
        SceneManager.LoadScene(2);
    }
}
