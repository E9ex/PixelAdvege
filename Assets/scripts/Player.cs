using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 5f;
    private Animator playerAnim;
    private bool kostuMu = false;
    [SerializeField] private GameObject bulletprefab;
    [SerializeField] private Transform bulletspawn;
    [SerializeField] private Transform bulletTile;

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
        if (col.CompareTag("Enemy"))
        {
            Destroy(gameObject,0.5f);//player i yok ediyor. şuan..
            playerAnim.SetTrigger("death");
        }
    }

    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(bulletprefab, bulletspawn.position, Quaternion.identity,bulletTile);
            playerAnim.SetTrigger("shoot");
        }
    }
}

