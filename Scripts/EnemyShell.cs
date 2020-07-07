using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShell : MonoBehaviour
{

    public GameObject enemyShellParticles;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision other)
    {
        Instantiate(enemyShellParticles, transform.position, Quaternion.identity);
        SoundManager.instance.ShellExplosion();


        MyHea myHealth = other.gameObject.GetComponent<MyHea>();
        if (myHealth != null)
        {
            myHealth.Takehit(4);
        }






        if (other.collider.tag== "player")
        {
            Debug.Log("enemy shell hit player");
        }
        Destroy(gameObject);
        Debug.Log(" enemy shell destroyed");
    }
    // Update is called once per frame

}
