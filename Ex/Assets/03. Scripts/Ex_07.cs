using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_07 : MonoBehaviour {

	void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "RCube")
        {
            Debug.Log("OnCollisionEnter");
        }
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.name == "RCube")
        {
            Debug.Log("OnCollisionStay");
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "RCube")
        {
            Debug.Log("OnCollisionExit");
        }
    }

    void OnTriggerEnter(Collider col)
    {
       if (col.gameObject.name == "LCube_Trigger")
        {
            Debug.Log("OnTriggerEnter");
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.name == "LCube_Trigger")
        {
            Debug.Log("OnTriggerStay");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "LCube_Trigger")
        {
            Debug.Log("OnTriggerExit");
        }
    }
}

//col.CompareTag(" - - ") > col.tag == " - - " (성능이 더 좋음)