using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Portal;
    public bool PortalOn;
    void Start()
    {
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
    }
}
