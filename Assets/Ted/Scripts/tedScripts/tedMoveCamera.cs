using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tedMoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tedWin.bigWin == false) { 
        transform.position = transform.position + new Vector3(tedStartGame.ConstantSpeed, 0, 0);
        }
    }
}
