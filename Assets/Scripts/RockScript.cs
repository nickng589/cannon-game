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

    void OnCollisionEnter2D(Collision2D coll)
    {
        //Debug.Log("HI");
        if (coll.gameObject.tag == "Projectile")
        {
            //Debug.Log("HIT");
        }
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER");
        }
    }
}
