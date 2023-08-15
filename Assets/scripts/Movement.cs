using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float jumpMagnitude = 5f;
    [SerializeField] Transform groundCheck;//This variable stores the position of empty sphere at the bottom of the player
    [SerializeField] LayerMask ground;//This stores the tile as A ground Layer
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpMagnitude, rb.velocity.z);
        }
        float LeftOrRight = Input.GetAxis("Horizontal");
        float FwdOrBwd = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(movementSpeed * LeftOrRight, rb.velocity.y, movementSpeed * FwdOrBwd);
    }

    bool isGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);// .3f is the size of the empty sphere at the bottom of the player

    }
}
