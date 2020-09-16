﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class scr_Stohwasser : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Bullet)
    {
        if (Bullet.gameObject.tag == "Bullet")
        {
            health = health - 1;
            StartCoroutine(dmg());
        }
    }

    IEnumerator dmg()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Damage;
        yield return new WaitForSeconds(0.5F);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Normal;
    }

    float Speed = 100;
    public bool irgendnennamen;
    public GameObject FixedStohwasser;
    private Transform target;
    public GameObject tar;
    public GameObject Bullet;
    public GameObject minibar;
    public GameObject Stohwasser;
    public Sprite Damage;
    public Sprite Normal;
    public Sprite bar2;
    public Sprite bar3;
    public Sprite bar4;
    public Sprite bar5;
    int health = 5;

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
        if (health <= 0)
        {
            Destroy(gameObject);
            Destroy(Stohwasser.gameObject);
        }

        minibar.transform.rotation = Quaternion.Euler(0, 0, 0);


        if (health == 4)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar2;
        }
        if (health == 3)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar3;
        }
        if (health == 2)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar4;
        }
        if (health == 1)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar5;

        }

        if (irgendnennamen == true)
        {
            FixedStohwasser.GetComponent<scr_Ericistdumm>().egalwie = true;
        }
    }
}
