using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_01 : MonoBehaviour {

    public GameObject myObject;

	void Start()
    {
        //myObject.SetActive(false);
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy: " + myObject.activeInHierarchy);
    }
}
