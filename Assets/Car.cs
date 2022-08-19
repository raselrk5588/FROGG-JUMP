using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 2f;

    public float miniSpeed = 2f;
    public float maxSpeed = 6f;


    void Start()
    {
        speed = Random.Range(miniSpeed, maxSpeed);
    }
    private void FixedUpdate()
    {
        Vector2 forword = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forword * Time.fixedDeltaTime * speed);
    }

}
