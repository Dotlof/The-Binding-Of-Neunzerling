using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_InstantiateBlocker : MonoBehaviour
{
    public bool trigger = true;
    private scr_RoomTemplates templates;
    // Start is called before the first frame update
    void Awake()
    {
        //Debug.Log("Test");
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<scr_RoomTemplates>();
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(5f);
        if(trigger == true)
            {
            Instantiate(templates.Blocker, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "RoomCenter" || collision.tag == "Destroyer")
        {
            Debug.Log("Test");
            trigger = false;
        }
    }

}
