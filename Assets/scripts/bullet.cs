using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{ 
    float direction;
    private Player _player;
    private void Awake()
    {
        _player = GameObject.FindObjectOfType<Player>();
    }
    void Start()
    {
        direction = _player.transform.localScale.x;
    }
    void Update()
    {
        transform.Translate(Vector2.right * direction * 10 * Time.deltaTime);
    }
}
