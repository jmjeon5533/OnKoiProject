using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    Player player;
    GameManager manager;
    Portal_in portal;
    [SerializeField] static bool[] PortalRate = new bool[4];
    /*
        public GameObject[] Stage1Sensor;
        public GameObject[] Stage2Sensor; 
    */

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        portal = GameObject.Find("portalOn").GetComponent<Portal_in>();
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
        #region 스테이지1
        if (portal.stage == 1) {
            if (CompareTag("FireSensor")) {
                if (player.fire)
                {
                    manager.PortalOn = true;
                }
            }
        }
        #endregion
        #region 스테이지2
        if (portal.stage == 2)
        {
            if (CompareTag("FireSensor"))
            {
                if (player.fire)
                {
                    PortalRate[0] = true;
                }
            }
            else if (CompareTag("WaterSensor"))
            {
                if (player.water)
                {
                    PortalRate[1] = true;
                }
            }
            else if (CompareTag("GrassSensor"))
            {
                if (player.grass)
                {
                    PortalRate[2] = true;
                }
            }
            else if (CompareTag("WindSensor"))
            {
                if (player.wind)
                {
                    PortalRate[3] = true;
                }
            }
            if (PortalRate[0] &&PortalRate[1] && PortalRate[2] && PortalRate[3])
            {
                manager.PortalOn = true;
            }
        }
        #endregion
    }
}
