using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Heizung : MonoBehaviour
{
    private void Healthbar()
    {
        if (health == 14)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar14;
        }
        if (health == 13)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar13;
        }
        if (health == 12)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar12;
        }
        if (health == 11)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar11;
        }
        if (health == 10)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar10;
        }
        if (health == 9)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar9;
        }
        if (health == 8)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar8;
        }
        if (health == 7)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar7;
        }
        if (health == 6)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar6;
        }
        if (health == 5)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar5;
        }
        if (health == 4)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar4;
        }
        if (health == 3)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar3;
        }
        if (health == 2)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar2;
        }
        if (health == 1)
        {
            minibar.gameObject.GetComponent<SpriteRenderer>().sprite = bar1;
        }
    }

    private void OnTriggerEnter2D(Collider2D Bullet)
    {
        if (Bullet.gameObject.tag == "Bullet")
        {
            Debug.Log("Dab");
            health--;
            StartCoroutine(dmg());
        }
    }

    IEnumerator dmg()
    {
        damageSprite = true;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Damage;
        yield return new WaitForSeconds(0.5F);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Normal;
        damageSprite = false;
    }

    public GameObject minibar;
    public Sprite bar14;
    public Sprite bar13;
    public Sprite bar12;
    public Sprite bar11;
    public Sprite bar10;
    public Sprite bar9;
    public Sprite bar8;
    public Sprite bar7;
    public Sprite bar6;
    public Sprite bar5;
    public Sprite bar4;
    public Sprite bar3;
    public Sprite bar2;
    public Sprite bar1;


    bool damageSprite = false;
    public Sprite Normal;
    public Sprite Damage;
    public float health = 15;
    public scr_Testchar PlayerReference;
    public GameObject Player;
    private Transform target;
    public Sprite Heizung2;
    public Sprite Heizung3;
    public Sprite Heizung4;
    public Sprite Heizung5;
    public Sprite Heizung1;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Playerloc").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < 200 && damageSprite == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Heizung5;
            PlayerReference.tot = true;
            Debug.Log(PlayerReference.tot);
        }
        else if (Vector2.Distance(transform.position, target.position) < 300 && damageSprite == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Heizung4;
        }
        else if (Vector2.Distance(transform.position, target.position) < 400 && damageSprite == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Heizung3;
        }
        else if (Vector2.Distance(transform.position, target.position) < 500 && damageSprite == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Heizung2;
        }
        else if (damageSprite == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Heizung1;
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }

        Healthbar();
    }
}
