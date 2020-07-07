using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankMove : MonoBehaviour
{

    // Start is called before the first frame update

    Rigidbody rbEnemyTank;
    float posX;
    float posZ;
    float posMin = -50F;
    float posMax = 50f;

    Vector3 targetPos;
    public float speedMove = 0.05f;
    public float speedRotate = 0.1f;


     void Awake()
    {
        rbEnemyTank = GetComponent<Rigidbody>();
        
    }
    void Start()
    {
        GetNewPosition();
    }
    void GetNewPosition()
    {
        posX = Random.Range(posMin, posMax);
        posZ = Random.Range(posMin, posMax);
        Vector3 newPosition = new Vector3(posX, transform.position.y, posZ);
        targetPos = newPosition;
    }



    // Update is called once per frame
    void Update()
    {
     if(Vector3.Distance(transform.position,targetPos)<10f)
        {
            GetNewPosition();
        }
        Rotate();
    }

     void FixedUpdate()
    {
        Move();        
    }

    void Rotate()
    {
        Vector3 tankDir = targetPos + transform.position;
        float step = speedRotate * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, tankDir, step, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDir);
    }


    void Move()
    {
        Vector3 moveForward = transform.forward * speedMove;
        rbEnemyTank.MovePosition(rbEnemyTank.position + moveForward);
    }


}
