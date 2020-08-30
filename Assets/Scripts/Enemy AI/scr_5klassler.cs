using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_5klassler : MonoBehaviour
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

    public void Pumpshot()
    {
        Pumpbullet.GetComponent<scr_Pumpbullet>();
        Instantiate(Pumpbullet, Pumpgun.transform.position, Quaternion.identity);
    }

    public void Snipeshot()
    {
        Sniperbullet.GetComponent<scr_Sniperbullet>();
        Instantiate(Sniperbullet, Sniperbullet.transform.position, Quaternion.identity);
    }

    public Sprite Damage;
    public Sprite Normal;
    public GameObject Sniper;
    public GameObject Sniperbullet;
    public GameObject Pumpgun;
    public GameObject Pumpbullet;
    float Speed = 100;
    int health = 10;
    private Transform target;

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(3f);
        Pumpshot();
        Pumpshot();
        Pumpshot();
        Pumpshot();
        Pumpshot();
        transform.localScale = new Vector3(-1, 1, 1);
        yield return new WaitForSeconds(3f);
        Snipeshot();
        transform.localScale = new Vector3(1, 1, 1);
        StartCoroutine(Shoot());
    }
    


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Playerloc").GetComponent<Transform>();
        Pumpshot();
        StartCoroutine(Shoot());
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        if (Vector2.Distance(transform.position, target.position) > 500)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
        }

    }
}
