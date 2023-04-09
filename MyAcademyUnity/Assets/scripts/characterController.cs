using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    Rigidbody charRb;
    Animator charAnim;
    [SerializeField]
    GameObject hedefBakis;
    public Transform cam;

    float hiz = 5;
    float ziplamaHizi = 200;
    bool zipla,ziplandiMi;
    [HideInInspector]
    float hizHorizontal,hizVertical,aci;


    void Start()
    {
        charRb = GetComponent<Rigidbody>();
        charAnim = GetComponent<Animator>();
    }

    void Update()
    {
        hizHorizontal = Input.GetAxis("Horizontal");
        hizVertical = Input.GetAxis("Vertical");
        

        if (Input.GetKeyDown(KeyCode.Space) && ziplandiMi == false)
        {
            zipla = true;
        }

        
    }

    private void FixedUpdate() 
    {
        Kosmak(hizHorizontal,hizVertical);
        Ziplamak(zipla);
       
        
        
    }

    private void OnCollisionEnter(Collision other) {
        
        if (other.transform.CompareTag("Zemin"))
        {
            ziplandiMi = false;
            charAnim.SetBool("Zipliyor",false);
        }
        
    }

    void Kosmak(float hizHorizontalKos,float hizVerticalKos)
    {
        if(hizHorizontalKos !=0 || hizVerticalKos !=0)
        {
            charRb.velocity = new Vector3(hizHorizontalKos*hiz,charRb.velocity.y,hizVerticalKos*hiz);
            transform.rotation = Quaternion.Lerp(transform.rotation, cam.transform.rotation,0.03f);
            //charRb.transform.LookAt(hedefBakis.transform);
            charAnim.SetBool("Kosuyor",true);
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
    void Donmek(float hizHorizontalPar, float hizVerticalPar)
    {
        if (hizHorizontalPar > 0.1 || hizHorizontalPar < -0.1 || hizVerticalPar > 0.1 || hizVerticalPar < -0.01)
        {
            hedefBakis.transform.position = new Vector3(gameObject.transform.position.x+10*hizHorizontalPar,gameObject.transform.position.y,gameObject.transform.position.z+10*hizVerticalPar);
            
        }
        
        
    }
}
