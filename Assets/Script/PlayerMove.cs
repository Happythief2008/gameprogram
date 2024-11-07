 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float maxSpeed;
    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void Update()
    {/*
        if(Input.GetButtonUp("Horizontal"))
        {
            rigid.velocity.normalized;
            rigid.veloity = new Vector2(0.5, rigid.velocity.y);
        }*/
    }
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");

        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if (rigid.velocity.x > maxSpeed) // Right max Speed
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        else if (rigid.velocity.x < maxSpeed*(-1)) // Left max Speed
            rigid.velocity = new Vector2(maxSpeed*(-1), rigid.velocity.y);
    }

}

