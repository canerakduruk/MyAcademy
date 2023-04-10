using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Network"))
        {
            Destroy(other.gameObject);
            Debug.Log("Destroyed object with tag Network");
        }
    }
}
