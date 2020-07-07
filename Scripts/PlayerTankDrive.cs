using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTankDrive : MonoBehaviour
{
    public float thrust;
    //public Rigidbody rb;
    public float speed;
    public GameObject a;

    public float rotspeed = 0.2f;
    // Use this for initialization
    /* void Start()
{

      rb = GetComponent<Rigidbody>();
  } */

    void Update()
    {


        if (Input.GetKey(KeyCode.Keypad6))

            transform.Rotate(0, rotspeed, 0);
        
         
        
        


        if (Input.GetKey(KeyCode.Keypad4))
            transform.Rotate(0, -rotspeed, 0);

        if (Input.GetKey(KeyCode.Keypad8))

            transform.Rotate(rotspeed, 0, 0);


        if (Input.GetKey(KeyCode.Keypad2))
            transform.Rotate(-rotspeed, 0, 0);

    }
    }
