using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D playerRigidbody;

    float xAxis;
    float yAxis;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        xAxis = Input.GetAxisRaw("Horizontal");
        yAxis = Input.GetAxisRaw("Vertical");

        move();
    }

    void move()
    {
        Vector2 movementVector = new Vector2(xAxis, yAxis);
        movementVector = movementVector * 4;
        playerRigidbody.velocity = movementVector;
    }
}
