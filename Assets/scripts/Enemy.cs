using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   private Animator enemyanim;

   private void Awake()
   {
      enemyanim = GetComponent<Animator>();
   }

   private void OnTriggerEnter2D(Collider2D col)
   {
      if (col.CompareTag("bullet"))
      {
         enemyanim.SetTrigger("deathenemyy");
      }
   }
}
