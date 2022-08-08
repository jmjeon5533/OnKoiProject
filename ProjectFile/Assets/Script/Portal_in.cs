//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Portal_in : MonoBehaviour
//{
//    GameManager manager;
//    public GameObject Camera;
//    public int stage = 1;
//    public GameObject Player;
//    public GameObject Portal;
//    void Start()
//    {
//        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
//        Camera.transform.position = new Vector3(0, 0, -10);
//    }

    
//    void Update()
//    {

//    }

//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (manager.PortalOn)
//        {
//            StageUp();
//        }
//    }
//    void StageUp() 
//    {
//        manager.PortalOn = false;
//        Camera.transform.position = new Vector3(0, 0 + (stage * 15),-10);
//        Player.transform.position = new Vector3(-11, -4 + (stage * 15), 0);
//        Portal.transform.position = new Vector3(10, 5.52f + (stage * 15), 0);
//        stage++;
//    }
//}
