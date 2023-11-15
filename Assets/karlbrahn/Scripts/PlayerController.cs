using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{

public GameObject player;

//Movement
public float speed;
public float jump;
float moveVelocity;
public Rigidbody2D rb;
bool isGrounded;

// Texts
bool textGone = false;
public GameObject text;
public TMP_Text textCoinCounter;

// Audios
public AudioSource audioSource;
public AudioClip jumpSound;
public AudioClip collectSound;

// Variables
public float coinCount;
private bool inAir;

// Animation
Animator animator;

void Start() 
{
    animator = GetComponent<Animator>();

    coinCount = 0;
}

void Update()
{
    if(isGrounded == true) {
        // Animation
        if(inAir == true) {
            animator.SetBool("inAir", false);
            inAir = false;
        }

        // Jumping
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
        
        // Jump sound
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
        audioSource.PlayOneShot(jumpSound);

            // remove text
            if (textGone == false) {
                textGone = true;
                Destroy(text, 1);
            }
        }
    }
    else {
        // Animation
        if(inAir == false) {
            animator.SetBool("inAir", true);
            inAir = true;
        }
    }

   moveVelocity = 0;

   //Left Right Movement
   if (Input.GetKey(KeyCode.LeftArrow))
   {
        moveVelocity = -speed;

        player.transform.localScale = new Vector3(-1f, 1f, 1f);
        //Animation
        animator.SetBool("isWalking", true);
   }
   else if (Input.GetKey(KeyCode.RightArrow))
   {
        moveVelocity = speed;

        player.transform.localScale = new Vector3(1f, 1f, 1f);
        //Animation
        animator.SetBool("isWalking", true);
   }
   else {
        //Animation
        animator.SetBool("isWalking", false);
   }

   GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

}
void OnCollisionEnter2D(Collision2D col)
{
    if(col.gameObject.tag=="platform") {
        Debug.Log("OnCollisionEnter2D");
        isGrounded = true;
    }
}

void OnCollisionExit2D(Collision2D col)
{
    if(col.gameObject.tag=="platform") {
        Debug.Log("OnCollisionExit2D");
        isGrounded = false;
    }
}

void OnTriggerEnter2D(Collider2D col) {
    if (col.gameObject.tag=="coin") {
        Destroy(col.gameObject);
        coinCount += 1;
        audioSource.PlayOneShot(collectSound);

        textCoinCounter.text = "Coins: " + coinCount;

        // All coins collected check
        if(coinCount > 5) {
            Destroy(this.gameObject, 3);
        }
    }
    else if (col.gameObject.tag=="door") {  // Door opens
        if(coinCount > 4) {
            Destroy(col.gameObject);
        }
    }
}

}