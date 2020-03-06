using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Battery")]
    [SerializeField] [Range(0, 20)] int batteryLife = 20;

    [Header("Movement")]
    [SerializeField] float thrustFactor = 1000;
    [SerializeField] float rotationFactor = 5;

    Rigidbody m_rigidbody;

    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Thrust();
        Rotate();
    }

    private void Rotate()
    {
        m_rigidbody.freezeRotation = true;

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationFactor * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rotationFactor * Time.deltaTime);
        }

        m_rigidbody.freezeRotation = false;
    }

    private void Thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            m_rigidbody.AddRelativeForce(Vector3.up * thrustFactor * Time.deltaTime);
        }
    }
}
