using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour

{

    private Rigidbody2D rockRigidbody;

    private Vector3 stageDimensions;

    public TextMesh number;

    [SerializeField]
    GameObject babyRock1;

    [SerializeField]
    public int size;

    // Start is called before the first frame update
    void Start()
    {
        stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        rockRigidbody = GetComponent<Rigidbody2D>();
        rockRigidbody.velocity = new Vector2(Random.Range(-2.0f, 2.0f), 5);
        number = (TextMesh) transform.GetChild(0).GetComponent(typeof(TextMesh));
        number.text = size.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -stageDimensions.y)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        //Debug.Log("HI");
        if (coll.gameObject.tag == "Projectile")
        {
            Debug.Log("HIT");
            babyRock1.SetActive(false);
            GameObject baby = Instantiate(babyRock1, transform.position, Quaternion.identity);
            baby.GetComponent<RockScript>().size = 0;
            baby.GetComponent<RockScript>().babyRock1 = babyRock1;
            baby.SetActive(true);
            //baby.GetComponent<RockScript>().rockRigidbody.velocity = new Vector2(Random.Range(-2.0f,1.0f), 5);
            Destroy(gameObject);
        }
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER");
        }
    }
}
