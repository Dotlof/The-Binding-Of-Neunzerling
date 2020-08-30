using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class scr_Pumpbullet : MonoBehaviour
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
    float speed = 200;
    Vector3 Left = new Vector3(-1, 0, 0);
    Vector3 Right = new Vector3(1, 0, 0);
    Vector3 Top = new Vector3(0, 1, 0);
    Vector3 Bottom = new Vector3(0, -1, 0);
    Vector3 Pos;
    private int randomx = 0;
    private int randomy = 0;
 
    private Transform target;

    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }

    void Awake()
    {
        randomx = Random.Range(-100, 100);
        randomy = Random.Range(-100, 100);
        target = GameObject.FindGameObjectWithTag("Playerloc").GetComponent<Transform>();
        Pos = target.position + new Vector3(randomx,randomy,0);
        StartCoroutine(Despawn());
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Pos, speed * Time.deltaTime);
        if (transform.position == Pos)
        {
            Destroy(gameObject);
        }
    }
}
