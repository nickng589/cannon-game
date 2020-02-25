using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D playerRigidbody;

    float xAxis;
    float yAxis;
    float cooldown;

    Vector3 stageDimensions;
    Vector2 size;

    [SerializeField]
    GameObject projectile;

    void Start()
    {
        cooldown = 0;
        playerRigidbody = GetComponent<Rigidbody2D>();
        stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        size = GetComponent<BoxCollider2D>().size;
        Debug.Log(stageDimensions.x);
        Debug.Log(stageDimensions.y);
        Debug.Log("width: " + size.x);
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
        Vector3 p = transform.position;
        Vector2 movementVector = new Vector2(xAxis, 0);
        movementVector = movementVector * 4;
        //playerRigidbody.velocity = movementVector;
        if (p.x > -stageDimensions.x + size.x/2 && movementVector.x <0)
        {
            playerRigidbody.velocity = movementVector;
            //Debug.Log("LEFT");
        }
        else if (p.x < stageDimensions.x - size.x / 2  && movementVector.x > 0)
        {
            playerRigidbody.velocity = movementVector;
        } else
        {
            playerRigidbody.velocity = new Vector2(0, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("HI");
    }
}
