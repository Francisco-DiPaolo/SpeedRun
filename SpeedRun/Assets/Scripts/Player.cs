using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float vel;
    private float horizontalInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /*private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        rb.AddRelativeForce(new Vector3(horizontalInput, 0, 0) * vel * Time.deltaTime);
    }*/

    void FixedUpdate()
    {
        if(Input.GetKey("left") || Input.GetKey("a"))
        {
            rb.AddRelativeForce(-vel, 0f, 0, ForceMode.Force);
        }

        if(Input.GetKey("right") || Input.GetKey("d"))
        {
            rb.AddRelativeForce(vel, 0f, 0, ForceMode.Force);
        }
    }
}
