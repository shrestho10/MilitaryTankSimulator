using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwanManager : MonoBehaviour
{
    public int maxEnemy = 5;
    int counter = 0;
    public GameObject[] tankPrefab;
    public Transform[] spwanPoints;
    public static EnemySpwanManager instance = null;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CoSetupEnemy");    
    }
    IEnumerable CoSetupEnemy()
    {
        while(counter < maxEnemy)
        {
            counter++;
            SpwanTank();
            yield return new WaitForSeconds(0f);
        }
    }

    public void SpwanTank()
    {
        int tankIndex = Random.Range(0, tankPrefab.Length);
        int spwanpointindex = Random.Range(0, spwanPoints.Length);
        Instantiate(tankPrefab[tankIndex], spwanPoints[spwanpointindex].position, Quaternion.identity);
    }

    // Update is called once per frame
  
}
