using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float ballSpeed = 30f;
    [SerializeField] private float jumpPower = 10f;

    private bool isGrounded = false;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
                Jump(jumpPower);
            }
        }
    }

    public void Jump(float jumpPower)
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpPower, rb.velocity.z);
        isGrounded = false;
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

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

}
