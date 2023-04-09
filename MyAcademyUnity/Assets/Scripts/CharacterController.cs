using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    Rigidbody charRb;
    Animator charAnim;
    
    
     public float speed;

    float x,z;
    Vector3 move = Vector3.zero;
    public Transform cam;
    
    public float XmouseRotation;
    public float YmouseRotation;
     public float mouse_sensivity;
    public float donusYumusatici =0.1f;
    float turnSmoothVelocity;

    float ziplamaHizi = 200;
    bool zipla,ziplandiMi;

    

    void Start()
    {
        charRb = GetComponent<Rigidbody>();
        charAnim = GetComponent<Animator>();
        
        
    }

    void Update()
    {
        x=Input.GetAxisRaw("Horizontal");
        z=Input.GetAxisRaw("Vertical");



        if (Input.GetKeyDown(KeyCode.Space) && ziplandiMi == false)
        {
            zipla = true;
        }

        
    }

    private void FixedUpdate() 
    {
       
        Ziplamak(zipla);
        Kosmak();
        
        
    }


    private void OnCollisionEnter(Collision other) {
        
        if (other.transform.CompareTag("Zemin"))
        {
            
            ziplandiMi = false;
            charAnim.SetBool("Zipliyor",false);
        }
        
    }

    void Kosmak()
    {
        XmouseRotation = Mathf.Clamp(XmouseRotation, -90, 90);
        
        XmouseRotation -= Input.GetAxis("Mouse Y") * mouse_sensivity * Time.deltaTime;
        YmouseRotation += Input.GetAxis("Mouse X") * mouse_sensivity * Time.deltaTime;
        charRb.transform.rotation = Quaternion.Euler(0, YmouseRotation, 0);
        cam.localRotation = Quaternion.Euler(0,YmouseRotation,0);
        if (x != 0 || z !=0)
        {
            charAnim.SetBool("Kosuyor",true);
            move = new Vector3(x,0,z)*Time.deltaTime*speed;
            charRb.MovePosition(transform.position + transform.TransformDirection(move));
        }
        else
        {
            charAnim.SetBool("Kosuyor",false);
        }
        
    }

    void Ziplamak(bool ziplaPar)
    {
        if (ziplaPar)
        {
            ziplandiMi = true;
            zipla = false;
            charRb.AddForce(Vector3.up*ziplamaHizi);
            charAnim.SetBool("Zipliyor",true);
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Rock"))
        {
            
        }
    }
    
}
