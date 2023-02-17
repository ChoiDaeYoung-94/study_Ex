using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Material : MonoBehaviour {

    public Transform randomT;

    public GameObject Cube;

    public Material a;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            a.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            Debug.Log("마우스 클릭!");
            randomT.position = new Vector3(Random.Range(-8f, 8f), Random.Range(0f, 4f), Random.Range(-8f, 8f));
            Instantiate(Cube, randomT.position, randomT.rotation);
        }
    }
}
