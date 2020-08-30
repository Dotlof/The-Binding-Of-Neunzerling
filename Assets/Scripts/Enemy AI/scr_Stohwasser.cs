using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class scr_Stohwasser : MonoBehaviour
{

    float Speed = 100;
    private Transform target;
    public GameObject tar;

    // Start is called before the first frame update
    void Start()
    {
        target = tar.GetComponent<Transform>();
        target = GameObject.FindGameObjectWithTag("Playerloc").GetComponent<Transform>();
    }

    private void FixedUpdate()
    {

    }


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);

    }
}
