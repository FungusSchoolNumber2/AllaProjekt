using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Change_Sprite : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite1;
    public Sprite newSprite2;
    public Sprite newSprite3;
    
    void ChangeSprite()
    {
        //spriteRenderer.sprite = newSprite;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spriteRenderer.sprite = newSprite1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spriteRenderer.sprite = newSprite2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spriteRenderer.sprite = newSprite3;
        }
    }
}
