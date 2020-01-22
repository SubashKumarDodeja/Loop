using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColor : MonoBehaviour
{
    private Color color1 ;
    private Color color2 ;
    private float duration = 3.0F;
    private Camera cam;


    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        color1 = Color.red;
            color2= Color.blue;
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        _timer +=Time.deltaTime;
        
        float t = Mathf.PingPong(Time.time, duration) / duration;
        cam.backgroundColor = Color.Lerp(color1, color2, t);
        if(_timer>0.0f && _timer<3.0f)
        {
            color1 = Color.red;
            color2= Color.blue;

        } 
        else if(_timer>3.0f && _timer<6.0f)
        {
            color1 = Color.blue;
            color2= Color.green;
            
        } else if(_timer>6.0f && _timer<9.0f)
        {
            color1 = Color.green;
            color2= Color.yellow;

        } else if(_timer>9.0f && _timer<12.0f)
        {
            color1 = Color.yellow;
            color2= Color.magenta;
            
            
        }else if(_timer>12.0f )
        {color1 = Color.magenta;
         color2= Color.red;

            _timer=0f;
        }
    }

    
}
