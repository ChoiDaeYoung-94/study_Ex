using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_05 : MonoBehaviour
{
    public Transform Player;

    public float speed;

    void Update()
    {
        transform.LookAt(Player);
        transform.position = Vector3.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
    }
}