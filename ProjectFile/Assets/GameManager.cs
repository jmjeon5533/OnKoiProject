using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Portal;
    public bool PortalOn;

    public GameObject help;
    bool ishelp = false;
    void Start()
    {
        help.SetActive(false);
        Portal.SetActive(PortalOn);
    }

    
    void Update()
    {
        Portal.SetActive(PortalOn);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ishelp = !ishelp;
            help.SetActive(ishelp);
            
        }
    }
}
