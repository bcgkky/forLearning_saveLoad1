using UnityEngine;
using TMPro;

public class Player1 : MonoBehaviour
{
    public int puan;
    public string ad;

    public TextMeshProUGUI puanText;
    public TextMeshProUGUI adText;

    void Start()
    {
        
        Load();
    }


    public void Save()
    {
        SaveSystem1.SavePlayer(this); //this, fonksiyon senden Player1 player değer vermeni isteyecek. Player1 sınıfı zaten burası.
    }

    public void Load()
    {
        PlayerData data = SaveSystem1.LoadPlayer(this);
        puanText.text = data.puan.ToString();
        adText.text = data.ad;

        puan = data.puan;
        ad = data.ad;
        
    }
}
