using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]float speed = 2.0f;
    int noOfHit = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        float z = Input.GetAxis("Vertical")*Time.deltaTime*speed;

        transform.Translate(x, 0, z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            noOfHit++;   // noOfhit= noOfHit+1 
            Debug.Log("collided with " + collision.gameObject.name);
            Debug.Log("Number of hit: " + noOfHit);
            collision.gameObject.tag = "Hit";
        }
   
    }
}
