using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_09 : MonoBehaviour {

    public Transform randomT;

    public GameObject Cube;

	void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("마우스 클릭!");
            randomT.position = new Vector3(Random.Range(-8f, 8f), Random.Range(0f, 4f), Random.Range(-8f, 8f));
            Instantiate(Cube, randomT.position, randomT.rotation);
        }
    }
}
