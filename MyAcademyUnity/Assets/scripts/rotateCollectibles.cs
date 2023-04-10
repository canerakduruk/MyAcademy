using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCollectibles : MonoBehaviour
{
    [SerializeField] private float speedX;
    

    void Update()
    {

        transform.Rotate(360 * speedX * Time.deltaTime, 0 , 0 );
        Debug.Log("calisti");
    }
}
