using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonController : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip clickSound;

    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.tag == "buttonStart") {
            gameObject.GetComponent<Button>().onClick.AddListener(StartGame);
        }
        
        if(gameObject.tag == "buttonExit") {
            gameObject.GetComponent<Button>().onClick.AddListener(ExitGame);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StartGame() {
        audioSource.PlayOneShot(clickSound);

        SceneManager.LoadScene("sceneGame");
    }

    private void ExitGame() {
        audioSource.PlayOneShot(clickSound);

        Application.Quit();
    }
}
