using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurretControl : MonoBehaviour
{
    public float rotspeed = 0.5f;
    bool left = false;
    bool right = false;
    public void RotateLeft()
    { left = true; }
    public void RotateRight()
    { right = true; }
    private void FixedUpdate()
    {
        if(left==true)
        { transform.Rotate(0,- rotspeed, 0);
        }
        if (right == true)
        {
            transform.Rotate(0,rotspeed, 0);
        }
    }
    public void RotateStop()
    {
        left = false;
         right = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
}
