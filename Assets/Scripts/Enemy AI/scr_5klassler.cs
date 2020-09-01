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

    public GameObject minibar;
    public Sprite bar2;
    public Sprite bar3;
    public Sprite bar4;
    public Sprite bar5;
    public Sprite bar6;
    public Sprite bar7;
    public Sprite bar8;
    public Sprite bar9;
    public Sprite bar10;
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
        minibar.transform.localScale = new Vector3(-3, 3, 1);
        yield return new WaitForSeconds(3f);
        Snipeshot();
        transform.localScale = new Vector3(1, 1, 1);
        minibar.transform.localScale = new Vector3(3, 3, 1);
        StartCoroutine(Shoot());
    }
    


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Playerloc").GetComponent<Transform>();
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


        if (health == 9)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar2;
        }
        if (health == 8)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar3;
        }
        if (health == 7)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar4;
        }
        if (health == 6)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar5;
        }
        if (health == 5)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar6;
        }
        if (health == 4)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar7;
        }
        if (health == 3)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar8;
        }
        if (health == 2)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar9;
        }
        if (health == 1)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar10;
        }
    }
}
