using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_07_1 : MonoBehaviour {

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerStay(Collider col)
    {     
        rb.AddForce(Vector3.up * 12.0f, ForceMode.Acceleration);
    }
}
