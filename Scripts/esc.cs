using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class esc : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject A;
    public static bool b = false;



    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
           

        }
    }

    
}