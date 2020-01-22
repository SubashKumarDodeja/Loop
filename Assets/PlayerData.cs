using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData {
    public float _highScore;


    public PlayerData(Player player){
        _highScore= player.highScore;
        

    }
}
