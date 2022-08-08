using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public int Stage;

    GameManager gameManager;

    private void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(/*SceneManager.GetActiveScene().name.Contains("Stage_1") && */GameManager.Instance.Portal_ON == true)
        {
            Clear();

            //들어가는 애니메이션 후

            SceneManager.LoadScene("Clear");
        }
    }

    void Clear()
    {
        Memory.In.Timer = GameManager.Instance.Timer;
    }
}
