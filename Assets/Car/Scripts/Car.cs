using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    Rigidbody rigid;
    public float forwardVelocity = 10;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            rigid.AddForce(Vector3.forward * forwardVelocity * 100, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigid.AddForce(Vector3.right * forwardVelocity * 100, ForceMode.Acceleration);
        }
    }
}
