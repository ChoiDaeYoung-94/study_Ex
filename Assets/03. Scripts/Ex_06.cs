using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_06 : MonoBehaviour {

	void Update()
    {
        if (Input.GetMouseButton(0))  //왼쪽 마우스 버튼을 누르는 동안 계속 실행
        {
            Debug.Log("GetMouseButton - 왼쪽");
        }
        else if (Input.GetMouseButtonDown(1)) //오른쪽 마우스 버튼을 누르는 순간 1번 실행
        {
            Debug.Log("GetMouseButtonDown - 오른쪽");
        }
        else if (Input.GetMouseButtonUp(2)) //휠을 누르고 때는 순간 1번 실행
        {
            Debug.Log("GetMouseButtonUp - 휠");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("GetKey - A");
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("GetKeyDown - B");
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            Debug.Log("GetKeyUp - C");
        }
        else if (Input.anyKey)
        {
            Debug.Log("anyKey");
        }
    }

    // 이 스크립트는 큐브에 적용된 스크립트, OnMouse함수는 스크립트를 적용한 오브젝트에 작용

    void OnMouseDrag() //큐브를 왼쪽 마우스 버튼으로 드레그하고있는 동안 계속 실행
    {
        Debug.Log("OnMouseDrag - Cube");
    }

    void OnMouseDown() //큐브를 왼쪽 마우스 버튼으로 클릭하는 순간 1번 실행
    {
        Debug.Log("OnMouseDown - Cube");
    }

    void OnMouseUp() //큐브를 왼쪽 마우스 버튼으로 클릭하고 때는 순간 1번 실행
    {
        Debug.Log("OnMouseUp - Cube");
    }

    void OnMouseOver() //마우스 커서가 큐브에 닿아있는 동안 계속 실행
    {
        Debug.Log("OnMouseOver - Cube");
    }

    void OnMouseEnter() //마우스 커서가 큐브에 닿는 순간 1번 실행
    {
        Debug.Log("OnMouseEnter - Cube");
    }

    void OnMouseExit() //마우스 커서가 큐브에서 나오는 순간 1번 실행
    {
        Debug.Log("OnMouseExit - Cube");
    }
}
