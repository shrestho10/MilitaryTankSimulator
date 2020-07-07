using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distance : MonoBehaviour
{
    public Transform one;
    public Transform two;
    public Text dist;
 
    public float dis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        dis =(one.transform.position.x - two.transform.position.x);
        dist.text= "" +dis.ToString("F1") + "meters";
    }
}
