using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_14_Gun : MonoBehaviour {

    public GameObject bulletPrefabs;

    public Transform bulletSpawn;
    public Transform RayTransform;

    void Update()
    {
        RaycastHit hit;

        Debug.DrawLine(bulletSpawn.position, RayTransform.position, Color.red);

        if (Physics.Raycast(bulletSpawn.position, (RayTransform.position - bulletSpawn.position).normalized, out hit))
        {
            if (hit.collider.gameObject.CompareTag("Box") && Input.GetKeyDown(KeyCode.Space))
            {
                Cmdfire();
            }
        }
    }

    void Cmdfire()
    {
        GameObject bullet = (GameObject)Instantiate(bulletPrefabs, bulletSpawn.position, bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6.0f;

        Destroy(bullet, 2f);
    }
}
