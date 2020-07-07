using System.Collections;
using System.Collections.Generic;
using TinForge.AircraftDemo.TinForge.AircraftDemo;
using UnityEngine;

public class EnemyHeal : MonoBehaviour
{
    // Start is called before the first frame update

    int enemyHealth = 12;
    int healthCounter;
    bool isDestroyed;
    public GameObject enemyTankParticle;
    public GameObject turret;
    public GameObject barrel;
    public GameObject barrel1;
    public GameObject barrel2;
    public GameObject barrel3;
    public GameObject barrel4;
    public GameObject barrel5;
    public GameObject barrel6;
    public GameObject HELICOPTER;
    public GameObject HELICOPTER1;


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
        EnemyTankMove enemytankmove = GetComponent<EnemyTankMove>();
        enemytankmove.enabled = false;
        barrel5.SetActive(false);
        barrel6.SetActive(false);
       
        HELICOPTER.SetActive(true);
        HELICOPTER1.SetActive(true);



    }
}
    