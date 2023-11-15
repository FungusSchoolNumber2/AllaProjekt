using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
         if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene("sceneGame");
         }

         if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene("sceneMenu");
         }
    }
}
