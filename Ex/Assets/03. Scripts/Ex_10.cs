using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_10 : MonoBehaviour {

    public GameObject sphere;

	void Start()
    {
        Invoke("makeSphere_Invoke", 2);
        InvokeRepeating("makeSphere_InvokeRepeating", 2, 1);
    }

    void makeSphere_Invoke()
    {
        Debug.Log("Invoke");
        float z = Random.Range(-5f, 5f);
        Instantiate(sphere, new Vector3(-4, 4, z), transform.rotation);
    }

    void makeSphere_InvokeRepeating()
    {
        Debug.Log("InvokeRepeating");
        float z = Random.Range(-5f, 5f);
        Instantiate(sphere, new Vector3(4, 4, z), Quaternion.identity);
    }
}

//transform.rotation == Quaternion.identity;
/*
 * 수학에서 X에 Y를 곱했을때 결과가 X 라면 Y를 identity 라고 부릅니다
일반적인 수학에서 identity 는 1입니다. 
Quaternion은 물체의 회전을 표현하는데 사용되는데 
Quaternion X 와 Quaternion Y를 곱했을 때 나오는 값이 X 라면 Y는 identity 입니다. 
어쨌든 간에, 유니티에서 보통 사용하는 목적은 회전을 기초값으로 초기화시키는 것입니다
transform.rotation = Quaternion.identity
라고 하면 모든 축의 회전값이 0으로 설정됩니다. 
identity 가 의미하는 회전값이 0이라서요. 
Quaternion의 곱은 두 회전을 의미하는데, 
X 축으로 30도 와 Y 축으로 30도를 돌리면 결과는 그 두 회전을 합친 Quaternion 이 되지만, 
어느 회전이든 identify 를 곱하면 곱하기 전의 값과 같으니까요. 
*/