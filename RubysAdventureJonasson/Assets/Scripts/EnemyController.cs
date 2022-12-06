using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;


    Rigidbody2D rigidbody2d;


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }
}
