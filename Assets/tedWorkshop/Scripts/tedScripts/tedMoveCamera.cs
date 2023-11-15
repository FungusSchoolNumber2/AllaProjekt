using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Win.bigWin == false) { 
        transform.position = transform.position + new Vector3(StartGame.ConstantSpeed, 0, 0);
        }
    }
}
