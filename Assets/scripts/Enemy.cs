using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy : MonoBehaviour
{
   private Animator enemyanim;
   public  Transform _enemy;

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
   private void Start()
   {
      animMove();
   }

   private void animMove()
   {
      _enemy.DOMoveX(-3.14f, 1f).SetLoops(-1, LoopType.Yoyo);
   }
}
