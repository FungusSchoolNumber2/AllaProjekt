using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    public static bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //checks if player has returned to ground

        if (col.CompareTag("Player"))
        {
            isGrounded = true;
            Debug.Log("LIVE");
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        //checks if player left the ground

        if (col.CompareTag("Player"))
        {
            isGrounded = false;
            Debug.Log("KILL");
        }
    }



}
