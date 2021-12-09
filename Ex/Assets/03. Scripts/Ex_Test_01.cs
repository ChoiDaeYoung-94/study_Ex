using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Test_01 : MonoBehaviour {

    public GameObject sphere;

    public Transform randomT;

    void Start()
    {
        InvokeRepeating("makeSphere_InvokeRepeating", 0, 0.5f);
    }

    void makeSphere_InvokeRepeating()
    {
        randomT.position = new Vector3(Random.Range(-4f, 4f), 5f, 0f);
        Instantiate(sphere, randomT.position, randomT.rotation);
    }
}
