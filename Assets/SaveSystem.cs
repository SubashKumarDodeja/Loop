
using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem {

    public static void SavePlayer(Player player)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string path = Application.persistentDataPath+ "/player.fun";

        FileStream fileStream = new FileStream(path,FileMode.Create);

        PlayerData playerData = new PlayerData(player);


        binaryFormatter.Serialize(fileStream,playerData);

        fileStream.Close();
    }


    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath+ "/player.fun";
        if(File.Exists(path))
        {
               BinaryFormatter binaryFormatter = new BinaryFormatter();
               FileStream fileStream = new FileStream(path,FileMode.Open);

              PlayerData player =  binaryFormatter.Deserialize(fileStream) as PlayerData;
              fileStream.Close();

              return player;

        }
        else{
            return null;
        }

        
    }
    
}
