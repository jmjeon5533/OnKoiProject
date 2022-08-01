using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensorgrass : MonoBehaviour
{
    Player player;
    GameManager manager;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Senser();
    }
    void Senser()
    {
        if (player.grass)
        {
            manager.PortalOn = true;
        }
    }
}
