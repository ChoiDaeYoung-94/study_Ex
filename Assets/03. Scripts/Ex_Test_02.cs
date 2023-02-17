using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Test_02 : MonoBehaviour {

    public GameObject sphere;

    public Transform randomT;

    void Start()
    {
        InvokeRepeating("makeSphere_InvokeRepeating", 0, 1);
    }

    void makeSphere_InvokeRepeating()
    {
        randomT.position = new Vector3(Random.Range(-7f, 7f), 5, Random.Range(-1f, 7f));
        Instantiate(sphere, randomT.position, randomT.rotation);
    }
}
