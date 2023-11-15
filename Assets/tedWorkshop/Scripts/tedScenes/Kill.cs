using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{

    public GameObject victim;
    public GameObject winner;
    private bool silly;

    // Start is called before the first frame update
    void Start()
    {
        silly = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
             silly = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            bool silly = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            bool silly = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //When this is called, it will give us the collider we touched as a parameter
        //We can touch lots of different colliders, so before we try to deal damage lets check what we are colliding with
        //This assumes that the player gameobject has been given a tag called "Player"
        if (col.CompareTag("Player"))
        {
            StartGame.ConstantSpeed = 0;
            Destroy(col.gameObject);
            Instantiate(victim, col.transform.position, col.transform.rotation);
            Debug.Log("Hiiiii");

            if (silly == true) ;
            {
                Instantiate(winner, col.transform.position, col.transform.rotation);
            }

        }
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //  Debug.Log("Hiiiii");
    //Destroy(other);
    //}

}
