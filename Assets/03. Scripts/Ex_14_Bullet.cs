using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_14_Bullet : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Box"))
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            Ex_15_LoadScene.sceneLoadNumber += 1;
        }
    }
}
