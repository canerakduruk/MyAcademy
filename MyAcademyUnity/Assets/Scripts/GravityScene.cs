using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScene : MonoBehaviour
{
    Rigidbody charRb;
    void Start()
    {
        charRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (charRb.useGravity == false)
            {
                charRb.useGravity = true;
            }
            else
            {
                charRb.useGravity = false;
            }
            
        }
    }
}
