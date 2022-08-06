using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float PlayerSpeed;
    public float PlayerJump;
    [SerializeField]
    bool isjump = false;

    public enum Elemental
    {
        Fire = 1,
        Water,
        Grass,
        Wind
    }

    public Elemental el = Elemental.Fire;
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
        Move();
        Jump();
        elemental();
        if (Input.GetKeyDown("delete")) //포탈 Off
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
    void elemental()
    {
        if (Input.GetKeyDown("1"))
        {
            el = Elemental.Fire;
        }
        else if (Input.GetKeyDown("2"))
        {
            el = Elemental.Water;
        }
        else if (Input.GetKeyDown("3"))
        {
            el = Elemental.Grass;
        }
        else if (Input.GetKeyDown("4"))
        {
            el = Elemental.Wind;
        }
    }
}
