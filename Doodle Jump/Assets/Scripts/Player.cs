using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    private float movement;
    [SerializeField] float movementSpeed = 5f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        Debug.Log(movement);
    }
    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        Debug.Log(" velo:" + velocity);
        velocity.x = movement;
        rb.velocity = velocity;
    }

    private void leftButton()
    {
        if (movement > 0)
        {
            //Vector2 veloco
        }
    }

}
