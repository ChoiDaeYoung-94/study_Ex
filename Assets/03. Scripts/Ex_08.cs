using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_08 : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "RCube")
        {
            Destroy(col.gameObject, 2f);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "LCube_Trigger")
        {
            Destroy(col.gameObject, 2f);
        }
    }
}
