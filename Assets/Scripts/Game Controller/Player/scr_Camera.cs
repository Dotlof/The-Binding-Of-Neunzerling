using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Camera : MonoBehaviour
{
    public int speed = 500;
    Vector3 offset = new Vector3(0, 0, -10);
    Vector3 Target;
    public GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera.transform.position = Vector3.MoveTowards(Camera.transform.position, Target, speed* Time.deltaTime);
        if(Camera.transform.position.z > -10)
        {
            Camera.transform.position += offset;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Room")
        {
            Target = collision.GetComponent<Transform>().position;
            //Camera.transform.position = collision.GetComponent<Transform>().transform.position + offset;
        }
    }

}
