using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foot : MonoBehaviour
{
    [SerializeField]  LayerMask layer;// bu değişken 'Raycast' işlemi için kullanılan layer'ı belirler.
    public  bool IsGround = true;// bu değişken zemine dokunulup dokunulmadığını kontrol eder.
    [SerializeField] Rigidbody2D rb;
    public float jumpspeed = 10f;
    void Update()
    {
        RaycastHit2D iscollider = Physics2D.Raycast(transform.position, Vector2.down, 0.09f, layer);
        if (iscollider!=null)
        {
            IsGround = true;
        }
        else
        {
            IsGround = false;
        }
        if (IsGround&&Input.GetKeyDown(KeyCode.Space)&&rb.velocity.y==0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpspeed);
        }
    }
}
