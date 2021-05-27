using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables 
    private float speed = 20.0f;
    private float turnSpeed = 25.02f;
    private float horizontalInput;
    private float forwardInput;

    // Public variables
    public Camera mainCamera;
    public Camera firstPersonCamera;
    public KeyCode switchKey;
    public string inputID;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Initialized input variables to get horizontal and vertical input 
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        

        // Move the vehicle forward based on vertical input 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotated the vehicle based on horizontal input 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
        // Switch camera perspective
        if(Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            firstPersonCamera.enabled = !firstPersonCamera.enabled;
        }
    }
}

   