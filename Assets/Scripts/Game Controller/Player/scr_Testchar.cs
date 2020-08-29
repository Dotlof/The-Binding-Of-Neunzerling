using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Testchar : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovementSpeed = 100;
    Vector3 movement;
    //Vector3 rotateR = new Vector3(1, 0, 0);
    //Vector3 rotateL = new Vector3(-1, 0, 0);
    public GameObject bullet;
    public GameObject AK;
    public bool RL;  //true=L, false=R

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

        if (movement.x > 0)
        {
            RL = false;
            transform.localScale = new Vector3(-1,1,1);
        }
        else
        {
            if (movement.x != 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
                RL = true;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }


    }
}
