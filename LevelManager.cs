using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;

    public PlayerController Player;
    
    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    public void RespawnPlayer(){
        Player.transform.position = currentCheckpoint.transform.position;
    }
}
