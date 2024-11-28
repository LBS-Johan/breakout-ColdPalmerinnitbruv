using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBouncer : MonoBehaviour
{
    Rigidbody2D myrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myrigidbody.velocity = new Vector2(0, 0);
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myrigidbody.velocity = new Vector2(5, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myrigidbody.velocity = new Vector2(-5, 0);
        }


    }

}
