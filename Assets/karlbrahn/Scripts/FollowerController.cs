using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerController : MonoBehaviour
{
    public float speed;

    public Animator animator;

    private GameObject player;

    private float horizontal;
    private float vertical;

    private float lastOffsetX;
    private float lastOffsetY;
    private float offsetX = 0;
    private float offsetY = 0;

    private Vector2 lastPos;
    private Vector2 curPos;

    public GameObject follower;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        // Old function name, changes scale to -1 or 1
        UpdateAnimator();

        if(horizontal != 0 || vertical != 0)
        {
            if(horizontal != 0)
            { offsetX = (horizontal < 0) ? Mathf.Floor(horizontal) : Mathf.Ceil(horizontal); }
            if(vertical != 0)
            { offsetY = (vertical < 0) ? Mathf.Floor(vertical) : Mathf.Ceil(vertical); }
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.transform.position.x - lastOffsetX, player.transform.position.y + (speed / 3)), speed * Time.deltaTime);
            lastOffsetX = offsetX;
            lastOffsetY = offsetY;
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.transform.position.x - lastOffsetX, player.transform.position.y + (speed / 3)), speed * Time.deltaTime);
        }
    }

    // Old function name, changes scale to -1 or 1
    void UpdateAnimator()
    {
        curPos = transform.position;
        if(curPos.x < lastPos.x || (curPos == lastPos && curPos.x > player.transform.position.x))
        {
            // Facing left
            follower.transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if(curPos.x > lastPos.x || (curPos == lastPos && curPos.x < player.transform.position.x))
        {
            // Facing Right
            follower.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        lastPos = curPos;
    }
}
