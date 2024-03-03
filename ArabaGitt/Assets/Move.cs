using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = 7.5f, boosts = 18f;

    public GameObject barricade;

    public GameObject text;

    public GameObject boost;

    public GameObject slow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject == barricade)
        {
            speed = 0;

            text.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == boost)
        {
            speed = boosts;
        }

        if(other.gameObject == slow)
        {
            speed = 7.5f;
        }
    }
}
