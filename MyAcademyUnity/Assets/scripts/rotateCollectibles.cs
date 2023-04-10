using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCollectibles : MonoBehaviour
{
    
    [SerializeField] private float speedZ;

    void Update()
    {
       
        transform.Rotate(0, 0, 360 * speedZ * Time.deltaTime);
    
    }
}
