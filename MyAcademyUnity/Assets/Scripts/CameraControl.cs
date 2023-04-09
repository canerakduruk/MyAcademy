using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    
    public Transform target;
    public float mouseSpeed;
    float xrot, yrot;
    public float minX,maxX;
    float hizHorizontal,hizVertical;
    void Start()
    {
        
    }
    private void Update() 
    {
        xrot -= Input.GetAxis("Mouse Y")*Time.deltaTime*mouseSpeed;
        yrot += Input.GetAxis("Mouse X")*Time.deltaTime*mouseSpeed;
        xrot = Mathf.Clamp(xrot,minX,maxX);
    }

    private void LateUpdate() 
    {
        transform.localRotation = Quaternion.Euler(0,yrot,0);
        transform.GetChild(0).localRotation = Quaternion.Euler(xrot,0,0);
    }

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position+new Vector3(0,0.5f,0),target.transform.position,0.3f);
        if(hizHorizontal !=0 || hizVertical !=0)
        {
            
        }
    }
}
