[System.Serializable] //herhangi bir objeye bağlı olmadığı için bu scripti serileştiriyor olmalısın.
public class PlayerData
{

    public int puan;
    public string ad;

    public PlayerData(Player1 player,bool ilkmi)
    {
        if (ilkmi)
        {
            puan = 0;
            ad = "--";
        }
        else
        {
            puan = player.puan;
            ad = player.ad;
        }
    }
    
}
