using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_GuideMissile_Enemy : MonoBehaviour {

    public Transform LeftP, RightP;

    private bool CheckedPosition = false;

	void Update()
    {
        if (CheckedPosition)
        {
            transform.position = Vector3.MoveTowards(this.transform.position, LeftP.position, 5.0f * Time.deltaTime);
        }else
        {
            transform.position = Vector3.MoveTowards(this.transform.position, RightP.position, 5.0f * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Box"))
        {
            CheckedPosition = !CheckedPosition;
        }
    }
}
