using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Test_01_Sphere : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }
}
