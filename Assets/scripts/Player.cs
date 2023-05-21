using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed= 5f;
    private Animator playerAnim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        move(h);
        playerturn(h);
    }

    void move(float h)
    {
        rb.velocity = new Vector2(h * speed, rb.velocity.y);
        playerAnim.SetBool("kosuyorMu",true);
        if (h==0)
            playerAnim.SetBool("kosuyorMu",false);
    }

    void playerturn(float h)
    {
        if (h < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (h > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
