using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y, Input.GetAxis("Vertical") * moveSpeed);
    }
    void Controller(string command)
    {
        if (command == "Left")
        {
            rb.velocity = new Vector3(-1 * moveSpeed, rb.velocity.y, rb.velocity.z);
        }
        else if (command == "Right")
        {
            rb.velocity = new Vector3(1 * moveSpeed, rb.velocity.y, rb.velocity.z);
        }
        else if (command == "Up")
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 1 * moveSpeed);
        }
        else if (command == "Down")
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -1 * moveSpeed);
        }
    }
}
