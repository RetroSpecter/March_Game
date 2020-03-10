using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody sphereCollider;
    public float forwardVelocity = 10;
    public float maximumVelocity = 100;
    public float friction = 10;
    public GameObject carModel;

    // Update is called once per frame
    void Update()
    {
        carModel.transform.position = sphereCollider.transform.position;
        if (Input.GetKey(KeyCode.UpArrow)) {
            sphereCollider.AddForce(carModel.transform.forward * forwardVelocity * 10, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            sphereCollider.AddForce(-carModel.transform.forward * forwardVelocity * 10, ForceMode.Acceleration);
        }

        float horiz = Input.GetAxis("Horizontal");
        carModel.transform.forward += carModel.transform.right * horiz * Time.deltaTime;

        Vector2 vel = sphereCollider.velocity;
        vel.y = 0;
        if (vel.magnitude > maximumVelocity) {
            sphereCollider.AddForce(-vel, ForceMode.VelocityChange);
        }
    }
}
