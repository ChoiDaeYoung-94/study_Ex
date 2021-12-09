using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_GuidedMissile_PlayerController : MonoBehaviour {

    public GameObject bulletPrefabs;

    public Transform bulletSpawn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Cmdfire();
        }
    }

    void Cmdfire()
    {
        GameObject bullet = (GameObject)Instantiate(bulletPrefabs, bulletSpawn.position, bulletSpawn.rotation);
        Destroy(bullet, 2.0f);
    }
}
