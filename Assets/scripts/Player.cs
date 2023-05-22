using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 5f;
    private Animator playerAnim;
    private foot _foot;
    public bool isjumpin = false;
   

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
        _foot = GameObject.FindObjectOfType<foot>();
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
      //  float y = Input.GetAxis("Vertical");
        move(h);
        playerturn(h);
        PlayerAnim(h);
        //JumpAnim();

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
        playerAnim.SetBool("kosuyorMu", true);
        if (h == 0)
        {
            playerAnim.SetBool("kosuyorMu", false);
        }
        else if (rb.velocity.y<-.1f)
        {
            playerAnim.SetBool("zipliyormU",false);
        }
    }

   /* public void JumpAnim()
    {
        if (_foot.transform.position.y == 0&&!isjumpin)
        {
            isjumpin = true;
            playerAnim.SetBool("zipliyormU",true);
        }
        else if(_foot.yerdeMi)
        {
            isjumpin = false;
            playerAnim.SetBool("zipliyormU",false);
        }
    }*/
}
