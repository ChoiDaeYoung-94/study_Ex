using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Test_03 : MonoBehaviour {

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(this.transform.position, Vector3.down, out hit, 5f))
        {
            if (hit.collider.gameObject.CompareTag("Box"))
            {
                rb.drag = 10f;
            }
        }
    }
}
