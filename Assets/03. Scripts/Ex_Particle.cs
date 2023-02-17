using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Particle : MonoBehaviour {

    public GameObject particle;

    void OnMouseDown()
    {
        particle.SetActive(!particle.activeSelf);
    }
}
