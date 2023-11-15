using System.Collections;
using System.Collections.Generic;
using Fungus;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LinusToolScript : MonoBehaviour
{
    public string Scene;
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangeScene()
    {
        Debug.Log("Loading: " + Scene);
        SceneManager.LoadScene(Scene, LoadSceneMode.Single);
    }
    
}
