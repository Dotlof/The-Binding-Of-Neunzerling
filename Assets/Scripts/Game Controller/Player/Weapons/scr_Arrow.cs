using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Arrow : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D stohwasser)
    {
        if (stohwasser.gameObject.tag == "Stohwasser")
        {
            Destroy(gameObject);
            Debug.Log("hit");
        }

    }


    float speed = 1200;
    public int LR;
    Vector3 moveLeft = new Vector3(-1, 0, 0);
    Vector3 moveRight = new Vector3(1, 0, 0);
    Vector3 moveTop = new Vector3(0, 1, 0);
    Vector3 moveBottom = new Vector3(0, -1, 0);

    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }

    void Awake()
    {
        Debug.Log(LR);
        StartCoroutine(Despawn());
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LR == 1)
        {
            transform.localScale = new Vector3(-2.5f, 2.5f, 1);
            transform.position += moveRight * speed * Time.deltaTime;
        }
        if (LR == 2)
        {
            transform.position += moveLeft * speed * Time.deltaTime;
            transform.localScale = new Vector3(2.5f, 2.5f, 1);
        }
        if (LR == 3)
        {
            transform.position += moveTop * speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 0, -90);
        }
        if (LR == 4)
        {
            transform.position += moveBottom * speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
    }
}
