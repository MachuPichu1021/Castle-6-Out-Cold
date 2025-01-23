using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMovement : MonoBehaviour
{
    public float speed;
    public Transform hand;
    private Rigidbody2D rb;
    private Transform anchor;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anchor = transform.GetChild(0);
    }

    void Update()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = speed * Input.GetAxis("Horizontal");
        velocity.y = speed * Input.GetAxis("Vertical");
        rb.velocity = velocity;
        hand.position = Vector3.Lerp(hand.position, anchor.position, Time.deltaTime*speed);
    }
}
