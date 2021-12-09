using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_02 : MonoBehaviour {

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate" + Time.deltaTime);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * 0.1f);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.down, turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

        Debug.Log("Update" + Time.deltaTime);
    }
}
