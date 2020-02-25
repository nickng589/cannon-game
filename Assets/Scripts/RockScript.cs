using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        //Debug.Log("HI");
        if (coll.gameObject.tag == "Projectile")
        {
            Debug.Log("HIT");
            Destroy(gameObject);
        }
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER");
        }
    }
}
