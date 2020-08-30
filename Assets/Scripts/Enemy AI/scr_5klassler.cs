using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_5klassler : MonoBehaviour
{

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

    public GameObject Sniper;
    public GameObject Sniperbullet;
    public GameObject Pumpgun;
    public GameObject Pumpbullet;
    float Speed = 100;
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
        if (Vector2.Distance(transform.position, target.position) > 500)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
        }

    }
}
