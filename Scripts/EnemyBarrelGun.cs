using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBarrelGun : MonoBehaviour
{
    public bool enemyShooting = false;
    public int fireRate = 3;
    public float force = 100f;
    public Transform barrelEnd;
    public Rigidbody enemyShellPrefab;
    Transform player;
    public Transform enemyTankHull;

    public float turretSpeed = 1f;




    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("srstank").transform;

        
    }

     void OnTriggerEnter(Collider other)
    {
    



        if (other.gameObject.tag == "Player" && enemyShooting == false )
        { enemyShooting = true;
            StartCoroutine("CoEnemyShootGun");
           


        }
       




    }
     void OnTriggerExit(Collider other)
    {
       
        if (other.gameObject.tag== "Player")
        { StopCoroutine("CoEnemyShootGun");
            enemyShooting = false;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
       
        

        if(enemyShooting == true)
        {

           
           Quaternion playerRotation = Quaternion.LookRotation(player.position - transform.position);
            float angle = Quaternion.Angle(playerRotation, transform.rotation);
            if (Vector3.Dot(transform.TransformDirection(Vector3.right), (player.position - transform.position)) < 0f)
            {
                transform.RotateAround(enemyTankHull.position, enemyTankHull.up, angle * Time.deltaTime * turretSpeed);
                
            }
            else
            {
                transform.RotateAround(enemyTankHull.position, enemyTankHull.up, angle * (-1f) * Time.deltaTime * turretSpeed);
            }
        }
    }

    IEnumerator CoEnemyShootGun()
    {
        
        while (true)
        {
           
            Shoot();
            yield return new WaitForSeconds(fireRate);



           
       }


        }


    void Shoot()
    {
        Rigidbody shell = Instantiate(enemyShellPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
        shell.velocity = -force * barrelEnd.forward;
        SoundManager.instance.ShootBarrelGun();
    }

}
