using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tedJump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpAmount = 300;

     // Start is called before the first frame update
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Grounded.isGrounded == true)
            {
                rb.AddForce(new Vector2(rb.velocity.x, jumpAmount));
                Debug.Log("slayyyy");
            }
        }
    }
}
