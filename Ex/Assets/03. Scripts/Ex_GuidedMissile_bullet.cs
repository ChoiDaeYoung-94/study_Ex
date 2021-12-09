using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_GuidedMissile_bullet : MonoBehaviour {

    public Transform Enemy;

    private void Start()
    {
        Enemy = GameObject.Find("Enemy").transform;
    }

    void Update()
    {
        this.transform.LookAt(Enemy);
        this.transform.position = Vector3.MoveTowards(this.transform.position, Enemy.position, 5 * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }  
    }
}
