using System.Collections;
using System.Collections.Generic;
using TinForge.AircraftDemo.TinForge.AircraftDemo;
using UnityEngine;

public class helicopter : MonoBehaviour
{
    // Start is called before the first frame update

    int enemyHealth = 12;
    int healthCounter;
    public bool isDestroyed ;
    public GameObject enemyTankParticle;
    public GameObject turret;
    public GameObject barrel;
    public GameObject barrel1;
    public GameObject barrel2;
    public GameObject barrel3;
    public GameObject barrel4;


    private void Awake()
    {
        healthCounter = enemyHealth;
    }

    public void Takehit(int amount)
    {
        if (isDestroyed)
        { return; }
        healthCounter -= amount;
        if (healthCounter <= 0)
        {
            EnemyDestroyed();
        }
        Debug.Log("enemy Tank health" + healthCounter);
    }

    void EnemyDestroyed()
    {


        isDestroyed = true;
        Instantiate(enemyTankParticle, transform.position, Quaternion.identity);
        turret.SetActive(false);
        barrel.SetActive(false);
        barrel1.SetActive(false);
        barrel2.SetActive(false);
        barrel3.SetActive(false);
        barrel4.SetActive(false);
        Hover tankmove = GetComponent<Hover>();
        tankmove.enabled = false;

    }
}
