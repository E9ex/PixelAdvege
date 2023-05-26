using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 5f;
    private Animator playerAnim;
    private bool kostuMu = false;
    public static int score = 0;
    private bullet _bullet;
    [SerializeField] public  Text scoretext;
    [SerializeField] private GameObject bulletprefab;
    [SerializeField] private Transform bulletspawn;
    [SerializeField] private Transform bulletTile;
    

    private void Awake()
    {
        _bullet = GetComponent<bullet>();
        rb = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
    }

    void Start()
    {
        scoretext.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
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

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("death")||(col.CompareTag("Enemy")))//yan barlara değersek oluyoruz.ve  değersek ona ölüyoruz.
        {
            die();
            GameManager.instance.StartCoroutine("restartScene");//singelton
        }
    }

    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(bulletprefab, bulletspawn.position, Quaternion.identity, bulletTile);
            playerAnim.SetTrigger("shoot");
        }
    }

    public void die()
    {
        Destroy(gameObject,0.5f); 
        playerAnim.SetTrigger("death");
    }
  
}

