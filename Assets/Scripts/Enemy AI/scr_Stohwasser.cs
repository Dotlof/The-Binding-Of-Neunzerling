using System.Collections;
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
    private Transform target;
    public GameObject tar;
    public GameObject Bullet;
    public Sprite Damage;
    public Sprite Normal;
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
        }

    }
}
