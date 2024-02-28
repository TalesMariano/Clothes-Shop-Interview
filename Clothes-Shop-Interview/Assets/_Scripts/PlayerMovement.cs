using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;

    Rigidbody2D rb;

    Vector2 movement;
    public Vector2 Movement {get { return movement; }}

    Vector2 direction;
    public Vector2 Direction { get { return direction; } }



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(movement.x != 0)
        {
            direction.x = Mathf.Floor(movement.x);
            direction.y = 0;
        }

        if (movement.y != 0)
            direction.y = Mathf.Floor(movement.y);


    }

    private void FixedUpdate()
    {

        movement.Normalize();
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
