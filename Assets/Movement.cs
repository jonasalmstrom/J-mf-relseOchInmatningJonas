using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    // Use this for initialization

    Rigidbody2D rb2d;
    public float movementSpeed;
   

    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(new Vector2(2f, 0f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(new Vector2(-2f, 0f));
        }

    }
}
