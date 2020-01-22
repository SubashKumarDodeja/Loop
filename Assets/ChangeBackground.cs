using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBackground : MonoBehaviour
{
    public GameObject Hexagon;
    public GameObject Triangle;
    
    void Start(){
        
    }

    void Update()
    {
            SettingData data =SaveSetting.LoadSetting();
        
        try{
             Debug.Log(data.shape);
        
        if(data.shape.Equals("Triangle"))
        {
            Hexagon.SetActive(false);
            Triangle.SetActive(true);
        
        } else if(data.shape.Equals("Hexagon"))
        {
            Hexagon.SetActive(true);
            Triangle.SetActive(false);
        }
        else{
            Hexagon.SetActive(true);
            Triangle.SetActive(false);
        }
        }
        catch{
           Hexagon.SetActive(true);
            Triangle.SetActive(false);
        }
       
        
    }
}
