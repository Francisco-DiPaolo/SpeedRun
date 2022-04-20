using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;

    public float vel;
    //public GameObject textDerrota;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //textDerrota.SetActive(false);
    }

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

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            textDerrota.SetActive(true);
        }
    }*/
}
