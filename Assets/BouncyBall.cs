using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBall : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    
        
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 11f;
        myRigidbody.velocity = myRigidbody.velocity.normalized * speed;

        

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Ball")) return;
        Destroy(gameObject);
       


        

    }

    
}
