using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D playerRigidbody;

    float xAxis;
    float yAxis;
    float cooldown;

    [SerializeField]
    GameObject projectile;

    void Start()
    {
        cooldown = 0;
        playerRigidbody = GetComponent<Rigidbody2D>();
        Vector3 stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        float width = GetComponent<SpriteRenderer>().bounds.size.x;
        //Debug.Log(stageDimensions.x);
        //Debug.Log(stageDimensions.y);
        //Debug.Log("width: " + width);
    }

    void Update()
    {
        xAxis = Input.GetAxisRaw("Horizontal");
        move();

        if (Input.GetKeyDown("space") && cooldown <= 0)
        {
            print("space key was pressed");
            Vector3 position = gameObject.transform.position;
            Instantiate(projectile, position, Quaternion.identity);
            cooldown = 0.3f;
        }
        if(cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
    }

    void move()
    {
        Vector2 movementVector = new Vector2(xAxis, 0);
        movementVector = movementVector * 4;
        playerRigidbody.velocity = movementVector;
        if (xAxis < 0)
        {
            //Debug.Log("LEFT");
        }
        else if (xAxis > 0)
        {
            //Debug.Log("RIGHT");
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("HI");
    }
}
