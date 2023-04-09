using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLoader : MonoBehaviour
{
    
    public GameObject erkek;
    public GameObject kiz;
    public GameObject erkekCam;
    public GameObject kizCam;
    string secilenCinsiyet;
    string secilenIsim;
    private void Awake() 
    {
        secilenCinsiyet= GameManager.cinsiyet;
        secilenIsim = GameManager.isim;
    }
    
    void Start()
    {
        if (secilenCinsiyet == "erkek")
        {
            erkek.SetActive(true);
            erkekCam.SetActive(true);
            kiz.SetActive(false);
            kizCam.SetActive(false);
        }
        else
        {
            kiz.SetActive(true);
            kizCam.SetActive(true);
            erkek.SetActive(false);
            erkekCam.SetActive(false);
        }
    }

    
    
}
