using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    float playerSpeed = 300f;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            rb.velocity = new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed, rb.velocity.y, Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Step")
        {
            rb.AddForce(0, 55, 0, ForceMode.Acceleration);
        }
    }
}
