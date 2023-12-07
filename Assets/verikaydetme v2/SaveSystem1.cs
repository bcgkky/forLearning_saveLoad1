using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; //saklanacak verileri dosyada saklamak için Binary(ikili) formatı kullancan, daha güvenli. //.bin

public static class SaveSystem1
{
   public static void SavePlayer(Player1 player)
    {

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream("bcgkky.bin", FileMode.Create);
        PlayerData data = new PlayerData(player, false);
        formatter.Serialize(stream, data);
        stream.Close();

    }
    public static PlayerData LoadPlayer(Player1 player) //hata vermemesi için return etmen gerekecek değerleri.
    {

        if (!File.Exists("bcgkky.bin"))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("bcgkky.bin", FileMode.Create);
            PlayerData data = new PlayerData(player, true);
            formatter.Serialize(stream, data);
            stream.Close();
        }





        if (File.Exists("bcgkky.bin"))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("bcgkky.bin", FileMode.Open);
            PlayerData data = formatter.Deserialize(stream) as PlayerData; //as PlayerData, objeyi playerdata ya dönüştüremez bu nedenle bunu kullandın.
            stream.Close();
            return data;
        }
        else
        {

            Debug.LogError("DOSYA YOK.");
            return null;
        }

    }
}
