#pragma warning disable 0618

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_14_1_box : MonoBehaviour {

    public GameObject ex_Effect;

    void Start()
    {
        ExpBox();
    }


	void OnCollisionEnter(Collision col)
    {
        //Instantiate(ex_Effect, col.transform.position, Quaternion.identity);
        GameObject effect = (GameObject)Instantiate(ex_Effect, col.transform.position, Quaternion.identity);
        Destroy(effect, effect.GetComponent<ParticleSystem>().duration);
    }

    void ExpBox()
    {
        Collider[] colls = Physics.OverlapSphere(this.transform.position, 100.0f);
        //지정한 원을 중심으로 10.0f 반경 내에 들어와 있는 Collider 객체 추출

        foreach (Collider coll in colls)
        {
            Rigidbody rb = GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(10.0f, transform.position, 100.0f, 10.0f);
                //폭발력, 원점, 반경, 위로 솟구치는 힘
            }
        }
    }
}
