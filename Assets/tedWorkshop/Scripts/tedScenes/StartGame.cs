using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject doodookaka;
    public static float ConstantSpeed;
    public static bool haveWeBegun;
 
    // Start is called before the first frame update
    void Start()
    {
        ConstantSpeed = 0;
        haveWeBegun = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            if (haveWeBegun == false) {
        
            ConstantSpeed = 0.02f;
            haveWeBegun = true;
            }

        }
    }
}
