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
        if (PortalOn)
        {
            Portal.SetActive(true);
        }
        else
        {
            Portal.SetActive(false);
        }
    }

    
    void Update()
    {
        if (PortalOn)
        {
            Portal.SetActive(true);
        }
        else
        {
            Portal.SetActive(false);
        }
        if (Input.GetKeyDown("5"))
        {
            ishelp = !ishelp;
            help.SetActive(ishelp);
            
        }
    }
}
