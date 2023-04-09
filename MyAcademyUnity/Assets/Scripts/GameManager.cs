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

    public static string isim;
    public static bool cinsiyet;
    public void OyunuKapat()
    {
        Application.Quit();
    }
    public void EgitimBaslat()
    {
        SceneManager.LoadScene("isiklisahne");
    }
    public void AnaSayfayaDon()
    {
        SceneManager.LoadScene(0);
    }

    public void ErkekSec()
    {
        erkek.SetActive(true);
        kadin.SetActive(false);
        cinsiyet = true;

    }
    public void KadinSec()
    {
        kadin.SetActive(true);
        erkek.SetActive(false);
        cinsiyet = false;
    }
    public void KarakterEkraniDevam()
    {
        isim = adInput.text;
        SceneManager.LoadScene(2);
    }
}
