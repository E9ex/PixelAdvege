using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foot : MonoBehaviour
{
    [SerializeField]  LayerMask layer;// bu değişken 'Raycast' işlemi için kullanılan layer'ı belirler.
   public  bool yerdeMi = true; // bu değişken zemine dokunulup dokunulmadığını kontrol eder.
    [SerializeField] Rigidbody2D rb;
    public float jumpspeed = 10f;
    [SerializeField] Animator playeraanim;
    private bool hasJumped = false;
    


    void Update()
    {
        RaycastHit2D iscollider = Physics2D.Raycast(transform.position, Vector2.down, 0.25f, layer);
        if (iscollider != null)
        {
            yerdeMi = true;
        }
        else
        {
            yerdeMi = false;
        }
        if (yerdeMi&&Input.GetKeyDown(KeyCode.Space)&&rb.velocity.y==0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpspeed);
           playeraanim.SetBool("zipliyormU",true);
        }
        /*else if (rb.velocity.y<-1f)
        {
            playeraanim.SetBool("zipliyormU",false);
        }*/
      
    }
}
