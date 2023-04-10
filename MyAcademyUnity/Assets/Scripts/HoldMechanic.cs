using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldMechanic : MonoBehaviour
{
    GameObject holder;
    GameObject tutulanNesne;
    Rigidbody tutulanNesneRb;
    bool firlat,tutuldu,tut;
    void Start()
    {
        holder = gameObject;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && tutuldu == true)
        {
            tut = false;
            tutuldu = false;
            firlat = true;
        }

       if (tut)
       {
            tutulanNesne.transform.position = holder.transform.position;
       }


        if (tutulanNesne != null)
        {
            Debug.Log(tutulanNesne.name);
        }

    }

    private void FixedUpdate() 
    {
        if(firlat)
        {
            Debug.Log("Çalıştı");
            firlat = false;
            tutulanNesneRb.AddForce(holder.transform.forward*10,ForceMode.Impulse);
            tutulanNesneRb.AddForce(holder.transform.up*5,ForceMode.Impulse);
            
        }
    }
    private void OnTriggerStay(Collider other) 
    {
        if (other.CompareTag("Object") && Input.GetKey(KeyCode.F) && firlat == false)
        {
            tutulanNesne = other.gameObject;
            tutulanNesneRb = tutulanNesne.GetComponent<Rigidbody>();
            tut = true;
            tutuldu = true;
        }
    }
}
