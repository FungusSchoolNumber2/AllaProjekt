using System.Collections;
using System.Collections.Generic;
using Fungus;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LinusToolScript : MonoBehaviour
{
    [CanBeNull] public string Scene;
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangeScene(string scene)
    {
        if (Scene == null)
        {
            Scene = scene;
        }
        
        Debug.Log("Loading: " + scene);
        SceneManager.LoadScene(Scene, LoadSceneMode.Single);
    }
    
}
