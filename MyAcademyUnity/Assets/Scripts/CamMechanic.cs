using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMechanic : MonoBehaviour
{
    public Transform target;
    float XmouseRotation;
    float YmouseRotation;
    public float mouse_sensivity;
   
    void Start()
    {
        
    }

    
    void Update()
    {
         XmouseRotation -= Input.GetAxis("Mouse Y")*Time.deltaTime*mouse_sensivity;
        YmouseRotation += Input.GetAxis("Mouse X")*Time.deltaTime*mouse_sensivity;
        
    }
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,target.transform.position,0.3f);
    }
    private void LateUpdate() 
    {
       
    }
}
