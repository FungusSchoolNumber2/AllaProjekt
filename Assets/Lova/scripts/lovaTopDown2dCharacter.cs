using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Add this script on a 2D-sprite.
// Needs a Rigidbody2D with Gravity Scale set to zero!

[RequireComponent(typeof(Rigidbody2D))]
public class lovaTopDown2dCharacter : MonoBehaviour
{
    public float maxSpeed = 7;
    public bool controlEnabled = true;
    public UnityEvent onSpaceDown;
    
    private Collider2D collider2d;
    private Vector2 move;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    private Vector2 direction;
    private Animator animator;

    //private protected iccreamcounter;

    private int icecreamAmount;

    void Awake()
    {
        collider2d = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        
        // Set gravity scale to 0 so player won't "fall" 
        rb.gravityScale = 0;
    }

    private void Update()
    {
        //icecreamcounter.text = "Icecream: " + icecreamAmount;
        
        // Get horizontal and vertical input
        if (controlEnabled)
        {
            move.x = Input.GetAxisRaw("Horizontal");
            move.y = Input.GetAxisRaw("Vertical");
        }
        else
        {
            move.x = 0;
            move.y = 0;
        }

        // If we press space we trigger the UnityEvent
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onSpaceDown.Invoke();
        }

    }
    
    private void FixedUpdate()
    {
        // Set velocity based on direction of input and maxSpeed
        rb.velocity = move.normalized*maxSpeed;

        if ((Mathf.Abs(rb.velocity.x) > 0) || (Mathf.Abs(rb.velocity.y) > 0))
        {
            animator.SetBool("walk", true);
        }
        else
        {
            animator.SetBool("walk", false);
        }
    }
}