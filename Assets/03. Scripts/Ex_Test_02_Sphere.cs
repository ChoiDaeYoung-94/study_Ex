using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Test_02_Sphere : MonoBehaviour {

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerStay(Collider col)
    {
        rb.AddForce(Vector3.up * 5.0f, ForceMode.VelocityChange);
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
