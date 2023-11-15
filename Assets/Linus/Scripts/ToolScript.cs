using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lovaToolScript : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangeScene(string scene)
    {
        
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        Debug.Log("Loading: " + scene);
    }
    
}
