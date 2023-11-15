using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationswitch : MonoBehaviour
{
    Animator animationshit;
    
    
    // Start is called before the first frame update
    void Start()
    {
        animationshit = GetComponent<Animator>();
           
        animationshit.SetBool("walk",false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("w"))
        {
            animationshit.SetBool("walk", true);
        }
        
        if (Input.GetKeyUp("w"))
        {
            animationshit.SetBool("walk", false);
        }
        
        if (Input.GetKeyDown("a"))
        {
            animationshit.SetBool("walk", true);
        }
        
        if (Input.GetKeyUp("a"))
        {
            animationshit.SetBool("walk", false);
        }
        
        if (Input.GetKeyDown("s"))
        {
            animationshit.SetBool("walk", true);
        }
        
        if (Input.GetKeyUp("s"))
        {
            animationshit.SetBool("walk", false);
        }
        
        if (Input.GetKeyDown("d"))
        {
            animationshit.SetBool("walk", true);
        }
        
        if (Input.GetKeyUp("d"))
        {
            animationshit.SetBool("walk", false);
        }
    }
}
