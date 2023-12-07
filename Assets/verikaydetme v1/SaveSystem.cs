using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; //saklanacak verileri dosyada saklamak için Binary(ikili) formatı kullancan, daha güvenli. //.bin

public static class SaveSystem
{
   public static void SavePlayer()
    {

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream("bcgkky.bin", FileMode.Create);
        formatter.Serialize(stream, Verilerimiz.puan);
        formatter.Serialize(stream, Verilerimiz.ad);
        stream.Close();

    }
    public static void LoadPlayer()
    {

        if (File.Exists("bcgkky.bin"))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("bcgkky.bin", FileMode.Open);

            Verilerimiz.puan = (int)formatter.Deserialize(stream);
            Verilerimiz.ad = (string)formatter.Deserialize(stream);
            stream.Close();
        }
        else
        {
            Debug.LogError("DOSYA YOK.");
        }

    }
}
