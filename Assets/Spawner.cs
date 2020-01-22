using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate=1f;

    public GameObject hexagonPrefab;
    public GameObject trianglePrefab;

    public GameObject _usedprefab=null;

    private float nextTimeTospawn=0f;

    // Start is called before the first frame update

    
    void Start()
    {
        SettingData data =SaveSetting.LoadSetting();
        
        try{
             Debug.Log(data.shape);
        
        if(data.shape.Equals("Triangle"))
        {
            _usedprefab=trianglePrefab;
        } else if(data.shape.Equals("Hexagon"))
        {
            _usedprefab=hexagonPrefab;
        }
        else{
            _usedprefab=hexagonPrefab;
        }
        }
        catch{
            _usedprefab=hexagonPrefab;
        }
       
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>=nextTimeTospawn)
        {
            Instantiate(_usedprefab,Vector3.zero,Quaternion.identity);
            nextTimeTospawn=Time.time + 1/spawnRate;
        }
    }
}
