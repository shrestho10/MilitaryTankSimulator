using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyHea : MonoBehaviour
{
    // Start is called before the first frame update
   public  Image bar;
    int myHealth = 500;
    public int healthCounter;
    bool isDestroyed;
    public GameObject myTankParticle;
    public GameObject turret;
    public GameObject barrel;
    public GameObject barrel1;
    public GameObject barrel2;
    public GameObject barrel3;
    public GameObject barrel4;
    public GameObject barrel5;
    public GameObject barrel6;
    public GameObject barrel7;
    public GameObject barrel8;
    public GameObject barrel9;
    public GameObject b;
    public GameObject menuContainer;

    private void Start()
    {
        bar = GetComponent<Image>();
        healthCounter = myHealth;
    }

  

    private void Awake()
    {
        healthCounter = myHealth;
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
        Debug.Log("my Tank health" + healthCounter);
    }

    void EnemyDestroyed()
    {


        isDestroyed = true;
        Instantiate(myTankParticle, transform.position, Quaternion.identity);
        turret.SetActive(false);
        barrel.SetActive(false);
        barrel1.SetActive(false);
        barrel2.SetActive(false);
        barrel3.SetActive(false);
        barrel4.SetActive(false);
        barrel5.SetActive(false);
        barrel6.SetActive(false);
        barrel7.SetActive(false);
        barrel8.SetActive(false);
        barrel9.SetActive(false);
        b.SetActive(true);
        menuContainer.SetActive(true);











}
}
