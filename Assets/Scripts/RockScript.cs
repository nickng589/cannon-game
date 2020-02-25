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
    GameObject babyRock2;

    [SerializeField]
    public int size;

    // Start is called before the first frame update
    void Start()
    {
        stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        rockRigidbody = GetComponent<Rigidbody2D>();
        rockRigidbody.velocity = new Vector2(Random.Range(-3.0f, 3.0f), Random.Range(5.0f,7.0f));
        number = (TextMesh) transform.GetChild(0).GetComponent(typeof(TextMesh));
        number.text = size.ToString();
        babyRock1 = Resources.Load("Prefabs/RockCopy") as GameObject;
        babyRock2 = Resources.Load("Prefabs/RockCopy") as GameObject;
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
            //Score.singleton.IncreaseScore(size);
            if (size > 1)
            {
                Debug.Log("HIT");
                //babyRock1.SetActive(false);
                GameObject baby = Instantiate(babyRock1, transform.position, Quaternion.identity);
                baby.GetComponent<RockScript>().size = size/2;
                //baby.GetComponent<RockScript>().babyRock1 = Resources.Load("Prefabs/RockCopy") as GameObject;
                //baby.GetComponent<RockScript>().babyRock2 = Resources.Load("Prefabs/RockCopy") as GameObject;
                GameObject baby2 = Instantiate(babyRock1, transform.position, Quaternion.identity);
                baby2.GetComponent<RockScript>().size = size / 2;
                //baby2.GetComponent<RockScript>().babyRock2 = Resources.Load("Prefabs/RockCopy") as GameObject;
                //baby2.GetComponent<RockScript>().babyRock1 = Resources.Load("Prefabs/RockCopy") as GameObject;
                //baby.SetActive(true);
            }
     
            Destroy(gameObject);
        }
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER");
        }
    }
}
