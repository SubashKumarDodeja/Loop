using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class SettingData {
    public string shape;
    public SettingData(Setting setting){
        shape= setting.shape;

    }
}
