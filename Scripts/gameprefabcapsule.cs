using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameprefabcapsule : MonoBehaviour
{

    public GameObject shellParticles;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision other)
    {
        Instantiate(shellParticles, transform.position, Quaternion.identity);
        SoundManager.instance.ShellExplosion();

        EnemyHeal enemyHealth = other.gameObject.GetComponent<EnemyHeal>();
        if (enemyHealth != null)
        {
            enemyHealth.Takehit(10);
        }


        Destroy(gameObject);
        Debug.Log("shell destroyed");
    }
    // Update is called once per frame

}
