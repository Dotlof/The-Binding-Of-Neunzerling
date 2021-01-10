using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class scr_Testchar : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D wifi)
    {
        Debug.Log(wifi);
        if (wifi.gameObject.tag == "Wifi")
        {
            StartCoroutine(Wifi());
            Destroy(wifi.gameObject);
        }
        if (wifi.gameObject.tag == "Stohwasser")
        {
            currentHealth--;
            wifi.GetComponent<scr_Stohwasser>().irgendnennamen = true;
            Debug.Log(wifi);
        }

        
    }

    IEnumerator Wifi()
    {
        MovementSpeed = 300;
        yield return new WaitForSeconds(10f);
        MovementSpeed = 187;
    }

    IEnumerator BowCooldown()
    {
        bowshot = true;
        yield return new WaitForSeconds(0.5f);
        bowshot = false;
    }


    // Start is called before the first frame update
    public bool tot = false;
    public float MovementSpeed = 100;
    Vector3 movement;
    //Vector3 rotateR = new Vector3(1, 0, 0);
    //Vector3 rotateL = new Vector3(-1, 0, 0);
    public GameObject bullet;
    public GameObject arrow;
    public GameObject AK;
    public GameObject Bow;
    public GameObject wifi;
    public int RL;  //true=L, false=R
    public int currentHealth = 3;
    public int Weapon = 1;
    public bool bowshot;
    bool bowshotFinished;



    public void Shoot()
    {
        if(Weapon == 1)
        {
            Debug.Log(RL);
            bullet.GetComponent<scr_Bullet>().LR = RL;
            Instantiate(bullet, AK.transform.position, Quaternion.identity);
        }
        if (Weapon == 2)
        {
            StartCoroutine(BowCooldown());
        }

    }


    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log(currentHealth);
        }

        if (tot == true)
        {
            currentHealth--;
            tot = false;
            Debug.Log(currentHealth);
        }


        movement.x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movement.x, 0, 0) * Time.deltaTime * MovementSpeed;

        movement.y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0, movement.y, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RL = 1;
            transform.localScale = new Vector3(-1,1,1);
            AK.transform.localRotation = Quaternion.Euler(0, 0, 45);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.localScale = new Vector3(1, 1, 1);
                AK.transform.localRotation = Quaternion.Euler(0, 0, 45);
                RL = 2;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AK.transform.localRotation = Quaternion.Euler(0,0,-45);
            RL = 3;
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                AK.transform.localRotation = Quaternion.Euler(0, 0, 135);
                RL = 4;
            }
            
        }


        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Shoot();
        }

        bowshotFinished = Bow.gameObject.GetComponent<scr_Bow>().bowshotFinished;
        if (bowshotFinished == true)
        {
            arrow.GetComponent<scr_Arrow>().LR = RL;
            Instantiate(arrow, Bow.transform.position, Quaternion.identity);
            Bow.gameObject.GetComponent<scr_Bow>().bowshotFinished = false;
        }


    }
}
