using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rgmachine : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;
    public float speed;

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }
    public float rotspeed = 0.2f;
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))

            transform.Rotate(0, rotspeed, 0);
           


        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(0, -rotspeed, 0);

        if (Input.GetKey(KeyCode.UpArrow))

            transform.Rotate(rotspeed, 0, 0);


        if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(-rotspeed, 0, 0);


    }
}
