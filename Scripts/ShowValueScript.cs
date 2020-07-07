using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowValueScript : MonoBehaviour
{
    Text t;
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Text>();
    }

public void textUpdate(float v)
    {
        t.text = Mathf.RoundToInt(v) + "km/sec";
    }
   
}
