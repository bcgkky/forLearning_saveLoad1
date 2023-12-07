using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public InputField GelenPuan;
    public InputField GelenAd;

    public TextMeshProUGUI puanText;
    public TextMeshProUGUI adText;

    void Start()
    {
        //Verilerimiz.ad = "Bcgkky";
        //Verilerimiz.puan = 45;
        Load();
    }


    public void Save()
    {
        Verilerimiz.puan = int.Parse(GelenPuan.text);
        Verilerimiz.ad = GelenAd.text;
        SaveSystem.SavePlayer();
    }
    public void Load()
    {
        SaveSystem.LoadPlayer();
        puanText.text = Verilerimiz.puan.ToString();
        adText.text = Verilerimiz.ad;
        
    }
}
