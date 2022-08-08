using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float PlayerSpeed;
    public float PlayerJump;
    public float RayCastline;
    public int elemental;
    //0 = 불, 1 = 물, 2 = 풀, 3 = 바람

    bool isjump = false;
    int Sensor_Check;

    public static Player Instance { get; private set; }

    GameManager gameManager;
    Rigidbody2D rigid;

    [SerializeField]
    void Start()
    {
        Instance = this;

        rigid = GetComponent<Rigidbody2D>();
        gameManager = /*GameObject.Find("GameManager").*/GetComponent<GameManager>();
    }

    void Update()
    {
        Move();
        Jump();
        //if (Input.GetKeyDown("delete")) //포탈 Off
        //{
        //    gameManager.PortalOn = false;
        //}
    }
    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, Vector3.down * RayCastline, Color.red);

        RaycastHit2D ray = Physics2D.Raycast(transform.position, Vector2.down, 
            RayCastline, LayerMask.GetMask("Ground"));

        if (ray.collider != null)
        {
            isjump = false;
        }
        else
        {
            isjump = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //원소 바꾸는 장치 상호작용
        if (collision.gameObject.CompareTag("Change"))
        {
            if (collision.gameObject.name.Contains("Fire"))
            {
                elemental = 0;
            }
            else if (collision.gameObject.name.Contains("Water"))
            {
                elemental = 1;
            }
            else if (collision.gameObject.name.Contains("Grass"))
            {
                elemental = 2;
            }
            else if (collision.gameObject.name.Contains("Wind"))
            {
                elemental = 3;
            }
        }

        //원소 활성화 장치 상호작용
        if (collision.gameObject.CompareTag("Sensor"))
        {
            if (collision.gameObject.name.Contains("Fire"))
            {
                Sensor_Check = 0;
            }else if (collision.gameObject.name.Contains("Water"))
            {
                Sensor_Check = 1;
            }
            else if (collision.gameObject.name.Contains("Grass"))
            {
                Sensor_Check = 2;
            }
            else if (collision.gameObject.name.Contains("Wind"))
            {
                Sensor_Check = 3;
            }
            
            //같은 원소인지 체크
            if(Sensor_Check == elemental)
            {
                if (collision.gameObject.name.Contains("fire"))
                {
                    GameManager.Instance.Fire = true;

                    //Sensor 코드에서 장치 활성화 애니메이션 함수 호출
                }else if (collision.gameObject.name.Contains("Water"))
                {
                    GameManager.Instance.Water = true;

                    //Sensor 코드에서 장치 활성화 애니메이션 함수 호출
                }
                else if (collision.gameObject.name.Contains("Grass"))
                {
                    GameManager.Instance.Grass = true;

                    //Sensor 코드에서 장치 활성화 애니메이션 함수 호출
                }
                else if (collision.gameObject.name.Contains("Wind"))
                {
                    GameManager.Instance.Wind = true;

                    //Sensor 코드에서 장치 활성화 애니메이션 함수 호출
                }
            }
        }
    }

    void Move()
    {
        if (Input.GetKey("a"))
        {
            transform.Translate((Vector3.left * PlayerSpeed) * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate((Vector3.right * PlayerSpeed) * Time.deltaTime);
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown("space"))
        {
            if (!isjump)
            {
                rigid.AddForce(Vector3.up * (PlayerJump * 10));
            }
        }
    }
}
