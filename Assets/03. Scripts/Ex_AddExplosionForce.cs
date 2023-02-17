using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_AddExplosionForce : MonoBehaviour {

	void Start()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, 10.0f);

        foreach(Collider col in cols)
        {
            Rigidbody rb = col.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.AddExplosionForce(1000.0f, transform.position, 10.0f, 5.0f);
            }
        }
    }
}
