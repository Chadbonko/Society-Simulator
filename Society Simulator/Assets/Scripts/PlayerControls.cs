using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float Speed = 10f;
    public float horizontaInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontaInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //We will move the player forward
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * forwardInput);
        //we'll move the player side to side
        transform.Translate(Vector3.right * Time.deltaTime * Speed * horizontaInput);


    }
}
