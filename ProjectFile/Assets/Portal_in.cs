using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal_in : MonoBehaviour
{
    GameManager manager;
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    
    void Update()
    {
            
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (manager.PortalOn)
        {
            SceneManager.LoadScene("Ingame2");
        }
    }
}
