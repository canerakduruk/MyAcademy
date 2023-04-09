using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    Rigidbody charRb;
    Animator charAnim;

    Transform cam;
    public float hiz = 5;
    public float donusYumusatici =0.1f;
    float turnSmoothVelocity;

    float horizontal,vertical;
    float ziplamaHizi = 200;
    bool zipla,ziplandiMi;

    

    void Start()
    {
        charRb = GetComponent<Rigidbody>();
        charAnim = GetComponent<Animator>();
        cam = Camera.main.transform;
    }

    void Update()
    {
        horizontal=Input.GetAxisRaw("Horizontal");
        vertical=Input.GetAxisRaw("Vertical");



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
        Vector3 direction = new Vector3(horizontal,0f,vertical).normalized;
        
        if (direction.magnitude >= 0.1f)
        {
            charAnim.SetBool("Kosuyor",true);
            float targetAngle = Mathf.Atan2(direction.x,direction.z) *Mathf.Rad2Deg+cam.eulerAngles.y;;
            float angle=Mathf.SmoothDampAngle(transform.eulerAngles.y,targetAngle,ref turnSmoothVelocity,donusYumusatici);
            transform.rotation = Quaternion.Euler(0f,angle,0f);

            Vector3 moveDir = Quaternion.Euler(0f,targetAngle,0f)*Vector3.forward;
            charRb.velocity = moveDir.normalized*hiz;
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
    
}
