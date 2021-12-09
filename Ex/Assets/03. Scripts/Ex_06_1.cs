using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_06_1 : MonoBehaviour {

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	void OnMouseDown()
    {
        rb.AddForce(transform.forward * 500.0f, ForceMode.Force);
        rb.useGravity = true;
    }
}


//rb.AddForce(transform.forward * 500.0f); 
// -> ForceMode.Force - 기본값
//리지드바디에 그것의 질량을 이용하여 계속적인 힘을 더한다.
//ForceMode.Acceleration -> 
//리지드바디에 계속적인 가속을 더하고 그것의질량은 무시한다. 
//ForceMode.Impulse ->
//그것의 질량을 이용하여 리지드바디에 충격력 인스턴트를 더한다. 
//ForceMode.VelocityChange ->
//리지드바디를 바꾸기 위해 속도 인스턴트를 더하며, 그것의 질량은 무시한다.