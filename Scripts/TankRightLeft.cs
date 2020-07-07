using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankRightLeft : MonoBehaviour
{
   
    public float thrust;
    public Rigidbody rb;
    public float speed;

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.D))

            transform.Rotate(0, 1, 0);


        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, -1, 0);

       

    }
}
