using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject rock;

    private Vector3 stageDimensions;

    [SerializeField]
    int delay;

    // Start is called before the first frame update
    void Start()
    {
        stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }

    void Awake()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            GameObject r = Instantiate(rock, new Vector3(Random.Range(-stageDimensions.x, stageDimensions.x), stageDimensions.y + 5), Quaternion.identity);
            r.GetComponent<RockScript>().size = (int) Mathf.Pow(2, Random.Range(2,5));
        }
    }
}
