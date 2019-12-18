using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 10f;
    public float horizontalInput;
    public float forwardInput;
    public float turnSpeed = 10f;
    private float gravityModifier = 1.5f;
    public float jumpForce;
    public bool isOnGround;
    private Rigidbody playerRb;



    void start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

    }


    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //We will move the player forward
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * forwardInput);
        //we'll move the player side to side
        transform.Rotate(Vector3.up * Time.deltaTime * Speed * horizontalInput * turnSpeed);


        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)

        {
            playerRb.AddForce(Vector3.up * jumpForce);
            isOnGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (CompareTag("Ground"))
        {

            isOnGround = true;

        }

    }

}
