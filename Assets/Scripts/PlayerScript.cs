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
        Vector3 stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        float width = GetComponent<SpriteRenderer>().bounds.size.x;
        Debug.Log(stageDimensions.x);
        Debug.Log(stageDimensions.y);
        Debug.Log("width: " + width);
    }

    void Update()
    {
        xAxis = Input.GetAxisRaw("Horizontal");

        move();
    }

    void move()
    {
        Vector2 movementVector = new Vector2(xAxis, 0);
        movementVector = movementVector * 4;
        playerRigidbody.velocity = movementVector;
        if(xAxis < 0)
        {
            Debug.Log("LEFT");
        } else if(xAxis > 0)
        {
            Debug.Log("RIGHT");
        }
    }
}
