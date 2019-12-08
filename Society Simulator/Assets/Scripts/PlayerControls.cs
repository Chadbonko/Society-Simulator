using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float Speed = 10f;
    public float horizontaInput;
    public float forwardInput;
    private Rigidbody playerRb;
    private float gravityModifier = 1.5f;
    public float jumpForce;
    public float turnSpeed;
    public bool isOnGround;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream:Society Simulator/Assets/Scripts/PlayerControls.cs
        horizontaInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //We will move the player forward
        transform.Translate(Vector3.back * Time.deltaTime * Speed * forwardInput);
        //we'll move the player side to side
        transform.Rotate(Vector3.up * Time.deltaTime * Speed * horizontaInput * turnSpeed);

        if (Input.GetKey(KeyCode.Space) && isOnGround)
=======
   
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
>>>>>>> Stashed changes:Society Simulator/Assets/Scripts/PlayerController.cs
        {
            playerRb.AddForce(Vector3.up * jumpForce);
            isOnGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    { 
        if (CompareTag ("Ground"))
        {

            isOnGround = true;

        }
      
    }



}
