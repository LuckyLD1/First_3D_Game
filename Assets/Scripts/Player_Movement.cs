using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    float playerMovementSpeed = 5f;
    float sprintMult = 2f;
    float sprintJumpMult = 1.3f;
    float jumpPower = 5f;
    bool landed = true;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerMovementSpeed *= sprintMult;
            jumpPower *= sprintJumpMult;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerMovementSpeed /= sprintMult;
            jumpPower /= sprintJumpMult;
        }
        if(Input.GetKey("w"))
        {
            gameObject.transform.position += new Vector3(0,0, playerMovementSpeed * Time.deltaTime);
        }
        if(Input.GetKey("a"))
        {
            gameObject.transform.position += new Vector3(playerMovementSpeed * Time.deltaTime * -1, 0, 0);
        }
        if(Input.GetKey("s"))
        {
            gameObject.transform.position += new Vector3(0, 0, playerMovementSpeed * Time.deltaTime * -1);
        }
        if(Input.GetKey("d"))
        {
            gameObject.transform.position += new Vector3(playerMovementSpeed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.Space) && landed)
        {
            rb.AddForce(new Vector3(0,jumpPower,0),ForceMode.Impulse);
            Debug.Log("Jumped");
            landed = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(!landed)
        {
            landed = true;
        }
    }
}
