using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour
{
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
        animator.SetBool("Running", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            animator.SetBool("Running", true);
        }

        if (Input.GetKeyUp("w"))
        {
            animator.SetBool("Running", false);
        }
    }
}
