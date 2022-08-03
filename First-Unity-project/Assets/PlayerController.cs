using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    private Rigidbody2D rb;
    
    void start(){
        rb = GetComponent<Rigidbody2D>();


    }

    void Update(){
        direction.x = Inpyt.GetAxisRaw('Horizontal')
        direction.y = Inpyt.GetAxisRaw('Vertical')

    }

    void FixedUpdate(){
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}

