using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 5f;
    private Animator playerAnim;
    public bool kostuMu = false;
    private foot _foot;
    private bool isjumpin = false;
    private void Awake()
    {
        _foot = GetComponentInChildren<foot>();
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
      // float y = Input.GetAxis("Vertical");
        move(h);
        playerturn(h);
        PlayerAnim(h);
        
    }

    void move(float h)
    {
        rb.velocity = new Vector2(h * speed, rb.velocity.y);
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

    public void PlayerAnim(float h)
    {  
        if (h != 0)
        {
            kostuMu = true;
        }
        else
        {
            kostuMu = false;
        }
        playerAnim.SetBool("kosuyorMu", kostuMu);
        
    }

}

