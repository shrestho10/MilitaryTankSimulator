using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scope : MonoBehaviour
{
    public GameObject cam;
    public GameObject scopes;
    public float x;

    public void Scopeset(float s)
    {
        x = s;
    }
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            cam.GetComponent<Camera>().fieldOfView = x;
            scopes.SetActive(true);
        }
        else


        {
            cam.GetComponent<Camera>().fieldOfView = 60;
            scopes.SetActive(false);
        }

    }
}
