using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    Rigidbody2D projectileRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        projectileRigidbody = GetComponent<Rigidbody2D>();
        projectileRigidbody.velocity = new Vector2(0, 5);
    }
}
