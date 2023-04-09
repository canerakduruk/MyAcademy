using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLoader : MonoBehaviour
{
    
    public GameObject erkek;
    public GameObject kiz;
    bool secilenCinsiyet;
    string secilenIsim;
    private void Awake() 
    {
        secilenCinsiyet= GameManager.cinsiyet;
        secilenIsim = GameManager.isim;
    }
    
    void Start()
    {
        if (secilenCinsiyet == true)
        {
            erkek.SetActive(true);
            kiz.SetActive(false);
        }
        else
        {
            kiz.SetActive(true);
            erkek.SetActive(false);
        }
    }

    
    void Update()
    {
        
    }
}
