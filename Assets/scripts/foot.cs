using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foot : MonoBehaviour
{
    [SerializeField]  LayerMask layer;// bu değişken 'Raycast' işlemi için kullanılan layer'ı belirler.
    public  bool IsGround = true;// bu değişken zemine dokunulup dokunulmadığını kontrol eder.
    [SerializeField] Rigidbody2D rb;
    public float jumpspeed = 10f;
    [SerializeField] private Animator playeranim;
    void Update()
    {
        RaycastHit2D iscollider = Physics2D.Raycast(transform.position, Vector2.down, 0.25f, layer); 

        if (iscollider.collider != null) 
            IsGround = true;
        else 
            IsGround = false;

       
        if (IsGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpspeed);
            playeranim.SetTrigger("zipliyorMu");
        }
     
    }
}

