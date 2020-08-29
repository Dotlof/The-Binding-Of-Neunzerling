using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class scr_Testchar : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("hit detected");
        StartCoroutine(Wifi());
        Destroy(other.gameObject);
        
    }

    IEnumerator Wifi()
    {
        MovementSpeed = 300;
        yield return new WaitForSeconds(10f);
        MovementSpeed = 187;
    }

    // Start is called before the first frame update
    public float MovementSpeed = 100;
    Vector3 movement;
    //Vector3 rotateR = new Vector3(1, 0, 0);
    //Vector3 rotateL = new Vector3(-1, 0, 0);
    public GameObject bullet;
    public GameObject AK;
    public int RL;  //true=L, false=R

    public void Shoot()
    {
        Debug.Log(RL);
        bullet.GetComponent<scr_Bullet>().LR = RL;
        Instantiate(bullet,AK.transform.position,Quaternion.identity);

        }

    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log(RL);
        
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


    }
}
