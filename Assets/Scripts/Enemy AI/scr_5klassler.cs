using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_5klassler : MonoBehaviour
{
    float Speed = 100;
    private Transform target;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Playerloc").GetComponent<Transform>();
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > 500)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
        }

    }
}
