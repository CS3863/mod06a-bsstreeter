using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 5.0f;
    public float turnspeed = 45.0f;
    public float horizontalInput;
    public float forwardInput; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //move vechile forward and backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //rotates car
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);
    }
}
