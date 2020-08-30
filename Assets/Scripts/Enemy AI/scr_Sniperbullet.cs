using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Sniperbullet : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D Enemy)
    {
        if (Enemy.gameObject.tag == "Playerloc")
        {
            Destroy(Enemy.gameObject);
            Destroy(gameObject);
            Debug.Log("hit");
        }

    }

    public GameObject Enemy;
    float Speed = 750;
    Vector3 Pos;
    private Transform target;


    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Playerloc").GetComponent<Transform>();
        Pos = target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Pos, Speed * Time.deltaTime);
        if (transform.position == Pos)
        {
            Destroy(gameObject);
        }
    }
}
