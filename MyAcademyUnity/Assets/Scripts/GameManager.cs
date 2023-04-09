using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject erkek;
    public GameObject kadin;
    public TMP_InputField adInput;


    public GameObject ekstralar;
    public GameObject anaMenu;
    public static string isim;
    public static string cinsiyet;
    public void OyunuKapat()
    {
        Application.Quit();
    }
    public void EgitimBaslat()
    {
        SceneManager.LoadScene(3);
    }
    public void AnaSayfayaDon()
    {
        SceneManager.LoadScene(0);
    }
    public void AnaSayfaOyna()
    {
        SceneManager.LoadScene(1);
    }

    public void Ekstralar()
    {
        ekstralar.SetActive(true);
        anaMenu.SetActive(false);
    }
    public void AnaMenuPanel()
    {
        anaMenu.SetActive(true);
        ekstralar.SetActive(false);
    }
    public void ErkekSec()
    {
        erkek.SetActive(true);
        kadin.SetActive(false);
        cinsiyet = "erkek";

    }
    public void KadinSec()
    {
        kadin.SetActive(true);
        erkek.SetActive(false);
        cinsiyet = "kadin";
    }
    public void KarakterEkraniDevam()
    {
        if (string.IsNullOrEmpty(adInput.text) || cinsiyet == null)
        {
            
        }
        else
        {
            isim = adInput.text;
            SceneManager.LoadScene(2);
        }
        
    }
}
