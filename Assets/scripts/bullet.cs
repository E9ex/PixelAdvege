using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.right*10f*Time.deltaTime);
    }
}
