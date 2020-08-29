using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Testchar : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovementSpeed = 100;
    Vector3 movement;

    /*public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (look)
        }
    }*/

    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movement.x, 0, 0) * Time.deltaTime * MovementSpeed;

        movement.y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0, movement.y, 0) * Time.deltaTime * MovementSpeed;

        if (movement.x > 0)
        {
            transform.localScale = new Vector3(-1,1,1);
        }
        else
        {
            if (movement.x != 0)
            {
                transform.localScale = new Vector3(1, 1, 1);

            }
            
        }
    }
}
