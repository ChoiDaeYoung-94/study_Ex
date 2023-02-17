using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_04_01_Camera : MonoBehaviour {

    public Transform targetObJect;
    public float dist = 10.0f;
    public float height = 3.0f;
    public float dampTrace = 20.0f;

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, 
            targetObJect.position - (targetObJect.forward * dist) + (Vector3.up * height), Time.deltaTime * dampTrace);

        transform.LookAt(targetObJect.position);
    }
}
