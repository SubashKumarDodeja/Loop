using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
public class Player : MonoBehaviour
{

    private float timer;
    private float moveSpeed=450f;
    float movement=0f;

    public float highScore;

    public float score;

    public Text TexthighScore;

    public Text Textscore;

    // Start is called before the first frame update
    void Start()
    {
        PlayerData data =SaveSystem.LoadPlayer();
        this.highScore=data._highScore;
    }

    // Update is called once per frame
    void Update()
    {
        timer +=Time.deltaTime;

    
        score = timer;
        Textscore.GetComponent<Text>().text="Score: "+score.ToString("F");
        TexthighScore.GetComponent<Text>().text="HighScore: "+highScore.ToString("F");

        if(score>highScore)
        {
            highScore=score;
            
            SaveSystem.SavePlayer(this);
        }
        
        movement= CrossPlatformInputManager.GetAxis("Horizontal")*15;
        if(movement>=0.5f)
        {
            if(movement>1)
            {
                movement=1;
            }
            transform.RotateAround(Vector3.zero,Vector3.forward,
            movement*Time.fixedDeltaTime*-moveSpeed);
        
        } else if(movement<=-0.5f)
        {
            
            if(movement<-1)
            {
                movement=-1;
            }
            transform.RotateAround(Vector3.zero,Vector3.forward,
            movement*Time.fixedDeltaTime*-moveSpeed);
        }
        
        Debug.Log(movement);
        

    }
    private void OnTriggerEnter2D()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
