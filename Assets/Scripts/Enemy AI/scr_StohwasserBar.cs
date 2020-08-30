using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class scr_StohwasserBar : MonoBehaviour
{
    public GameObject Stohwasser;
    private Transform target;
    Vector3 change;
    float Speed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        target = Stohwasser.GetComponent<Transform>();
        change = new Vector3(-1,43,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position + change, Speed * Time.deltaTime);
    }
}
