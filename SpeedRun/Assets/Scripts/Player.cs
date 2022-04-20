using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float vel;
    public float jumpForce = 1;
    bool grounded = true;
    
    float horizontalInput;
    public float horizontalMultiplier = 2;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * vel * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * vel * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump();
        }
    }
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    void Jump()
    {
        rb.AddRelativeForce(0f, 1f * jumpForce, 0f, ForceMode.Impulse);
        grounded = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Grounded"))
        {
            Debug.Log("Estoy en el piso");
            grounded = true;
        }
    }
    /*void FixedUpdate()
    {
        if(Input.GetKey("left") || Input.GetKey("a"))
        {
            rb.AddRelativeForce(-vel, 0f, 0, ForceMode.Force);
        }

        if(Input.GetKey("right") || Input.GetKey("d"))
        {
            rb.AddRelativeForce(vel, 0f, 0, ForceMode.Force);
        }
    }*/
}
