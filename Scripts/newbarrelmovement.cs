using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newbarrelmovement : MonoBehaviour
{
    public float m_TurnSpeed = 180f;
    public float m_TurnInputValue;             // The current value of the turn input.
    public float m_OriginalPitch;
    public Rigidbody m_Rigidbody;
    public string m_TurnAxisName;
    // Start is called before the first frame update
    public void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
    public void OnEnable()
    {
        // When the tank is turned on, make sure it's not kinematic.
        m_Rigidbody.isKinematic = false;

        // Also reset the input values.
       
        m_TurnInputValue = 0f;
    }
    public void OnDisable()
    {
        // When the tank is turned off, set it to kinematic so it stops moving.
        m_Rigidbody.isKinematic = true;
    }

    void Start()
    {
        m_TurnAxisName = "Horizontal";
    }

    // Update is called once per frame
    void Update()
    {
        m_TurnInputValue = Input.GetAxis("Horizontal");
    }

    public void FixedUpdate()
    {
        // Adjust the rigidbodies position and orientation in FixedUpdate.
      
        Turn();
    }
    public void Turn()
    {
        // Determine the number of degrees to be turned based on the input, speed and time between frames.
        float turn = m_TurnInputValue * m_TurnSpeed * Time.deltaTime;

        // Make this into a rotation in the y axis.
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

        // Apply this rotation to the rigidbody's rotation.
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turnRotation);
    }
}
