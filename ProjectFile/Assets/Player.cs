using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float PlayerSpeed;
    public float PlayerJump;
    [SerializeField]
    bool isjump = false;

    public bool fire = true;
    public bool water = false;
    public bool grass = false;
    public bool wind = false;
    GameManager manager;

    public float RayCastline;

    Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Translate((Vector3.left * PlayerSpeed) * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate((Vector3.right * PlayerSpeed) * Time.deltaTime);
        }
        if (Input.GetKeyDown("space"))
        {
            if (!isjump)
            {
                rigid.AddForce(Vector3.up * (PlayerJump * 10));
            }
        }
        if (Input.GetKeyDown("1"))
        {
            fire = true;
            water = false;
            grass = false;
            wind = false;
        }
        else if (Input.GetKeyDown("2"))
        {
            fire = false;
            water = true;
            grass = false;
            wind = false;
        }
        else if (Input.GetKeyDown("3"))
        {
            fire = false;
            water = false;
            grass = true;
            wind = false;
        }
        else if (Input.GetKeyDown("4"))
        {
            fire = false;
            water = false;
            grass = false;
            wind = true;
        }
        if (Input.GetKeyDown("delete")) //ġƮ
        {
            manager.PortalOn = false;
        }
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
}
