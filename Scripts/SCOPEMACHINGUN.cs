using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCOPEMACHINGUN : MonoBehaviour
{
    public GameObject cam;
    public GameObject scopes;
    public int x;

    public void scopeset(int s)
    {
        x = s;
    }
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            cam.GetComponent<Camera>().fieldOfView =x;
            scopes.SetActive(true);
        }
        else


        {
            cam.GetComponent<Camera>().fieldOfView = 90;
            scopes.SetActive(false);
        }

    }
}
