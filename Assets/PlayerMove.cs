using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float speedMove;
    public Vector2 movement;

    public Joystick joystickMovement;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement.x = joystickMovement.Horizontal;
        movement.y = joystickMovement.Vertical;
    }

    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + movement * speedMove * Time.fixedDeltaTime);
    }
}
