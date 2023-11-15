using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This component can be used to access methods for changing the scene, and quitting the game
// It can be used together with UnityEventOnTrigger, or UI-button-events, to decide when a scene should be changed or the game should be closed
public class EchoApplicationHandler : MonoBehaviour
{
    public void ChangeSceneStart()
    {
        // Load the scene named "NewScene"
        SceneManager.LoadSceneAsync("W2", LoadSceneMode.Single);
    }
    
    public void ChangeSceneWin()
    {
        // Load the scene named "NewScene"
        SceneManager.LoadSceneAsync("WinScene", LoadSceneMode.Single);
    }
    

    public void QuitGame()
    {
        Application.Quit();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            QuitGame();
        }
            
    }
}
