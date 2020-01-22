using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public string shape;
    public void Triangle(){
        shape="Triangle";

        SaveSetting.SettingSave(this);
    }

    public void Hexagon(){
        shape="Hexagon";
        SaveSetting.SettingSave(this);
    }

    
}
