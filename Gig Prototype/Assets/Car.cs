using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]float accelerationModifier = 1000;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        if(Input.GetAxis("Horizontal") < 0)
        {
            Debug.Log("Turn Left");
            rb.AddRelativeForce(Vector3.left * accelerationModifier * Time.deltaTime);
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            Debug.Log("Turn Right");
            rb.AddRelativeForce(Vector3.right * accelerationModifier * Time.deltaTime);
        }

        if(Input.GetAxis("Vertical") > 0)
        {
            Debug.Log("Move Forward");
            rb.AddRelativeForce(Vector3.forward * accelerationModifier * Time.deltaTime);

        }
        else if(Input.GetAxis("Vertical") < 0)
        {
            Debug.Log("Slow Down or Move Backwards");
            rb.AddRelativeForce(Vector3.back * accelerationModifier * Time.deltaTime);
        }
    }
}
