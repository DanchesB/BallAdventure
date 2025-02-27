using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float ballSpeed = 30f;
    [SerializeField] private float jumpPower = 10f;

    private Rigidbody rb;
    Vector3 rotateDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Jump()
    {
        
    }

    private void Movement()
    {
        float xRot = 0f;
        float zRot = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            xRot = 1f;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            xRot = -1f;
        }
        else
        {
            xRot = 0f;
        }
            
        if (Input.GetKey(KeyCode.A))
        {
            zRot = 1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            zRot = -1f;
        }
        else
        {
            zRot = 0f;
        }

        float xRotation = xRot * ballSpeed * Time.fixedDeltaTime;
        float zRotation = zRot * ballSpeed * Time.fixedDeltaTime;

        rb.AddTorque(Vector3.right * xRotation);
        rb.AddTorque(Vector3.forward * zRotation);
    }
}
