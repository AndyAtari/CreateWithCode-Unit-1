using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncomingPlaneController : MonoBehaviour
{
    private float speed;
    private float liftoff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves plane forward and up at consistent speed/rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.up * Time.deltaTime * liftoff);
    }
}
