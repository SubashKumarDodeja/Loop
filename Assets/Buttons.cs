using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void Play(){
          SceneManager.LoadScene("Scene1");
    } 

    public void Setting(){

    }

    public void Quit(){
        Application.Quit();
    }
}
