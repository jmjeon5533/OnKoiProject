using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //¼öÁ¤ Àü
    //public GameObject Portal;
    //public bool PortalOn;

    //public GameObject help;
    //bool ishelp = false;
    //void Start()
    //{
    //    help.SetActive(false);
    //    Portal.SetActive(PortalOn);
    //}


    //void Update()
    //{
    //    Portal.SetActive(PortalOn);

    //    if (Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        ishelp = !ishelp;
    //        help.SetActive(ishelp);

    //    }
    //}
    public static GameManager Instance { get; private set; }

    public bool Fire;
    public bool Water;
    public bool Grass;
    public bool Wind;
    public bool Portal_ON;

    public float Timer;


    private void Start()
    {
        Instance = this;
    }

    private void Update()
    {
        if(Fire == true && Water == true && Grass == true && Wind == true)
        {
            Portal_ON = true;
        }

        Timer += Time.deltaTime;
    }
}
