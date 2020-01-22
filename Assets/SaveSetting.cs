using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class  SaveSetting 
{
    public static void SettingSave(Setting setting)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string path = Application.persistentDataPath+ "/setting.fun";

        FileStream fileStream = new FileStream(path,FileMode.Create);


        SettingData settingData = new SettingData(setting);

        binaryFormatter.Serialize(fileStream,settingData);

        fileStream.Close();
    }


    public static SettingData LoadSetting()
    {
        string path = Application.persistentDataPath+ "/setting.fun";
        if(File.Exists(path))
        {
               BinaryFormatter binaryFormatter = new BinaryFormatter();
               FileStream fileStream = new FileStream(path,FileMode.Open);

              SettingData setting =  binaryFormatter.Deserialize(fileStream) as SettingData;
              fileStream.Close();

              return setting;

        }
        else
        {
            return null;
        }

        
    }
}
