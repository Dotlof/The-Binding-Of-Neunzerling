using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_RoomSpawner : MonoBehaviour
{
    private scr_RoomTemplates templates;
    private int randnumb;
    public bool spawned = false;
    //bool onSpawn = false;

    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<scr_RoomTemplates>();
        Invoke("Spawn", 0.1f);
    }

    public int openingDirection;
    //1 needs bottom door
    //2 needs top door
    //3 needs left door
    //4 needs right door

    void Spawn()
    {

        if (spawned == false)
        {

            if (openingDirection == 1)
            {
                //Spawn room with bottom door
                randnumb = Random.Range(0, templates.bottomRooms.Length);
                Instantiate(templates.bottomRooms[randnumb], transform.position, templates.bottomRooms[randnumb].transform.rotation);

            }
            else if (openingDirection == 2)
            {
                //spawn room with top door
                randnumb = Random.Range(0, templates.topRooms.Length);
                Instantiate(templates.topRooms[randnumb], transform.position, templates.topRooms[randnumb].transform.rotation);

            }
            else if (openingDirection == 3)
            {
                //Spawn room with left door
                randnumb = Random.Range(0, templates.leftRooms.Length);
                Instantiate(templates.leftRooms[randnumb], transform.position, templates.leftRooms[randnumb].transform.rotation);

            }
            else if (openingDirection == 4)
            {
                //Spawn room with right door
                randnumb = Random.Range(0, templates.rightRooms.Length);
                Instantiate(templates.rightRooms[randnumb], transform.position, templates.rightRooms[randnumb].transform.rotation);

            }
            spawned = true;
        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "roomSpawnPoint"/*&& other.GetComponent<scr_RoomSpawner>().spawned == true*/)
        {
            //Instantiate(templates.Blocker, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

}