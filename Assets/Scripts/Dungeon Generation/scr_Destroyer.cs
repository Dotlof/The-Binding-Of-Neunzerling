using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == ("roomSpawnPoint"))
        {
            Destroy(collision.gameObject);
            //Debug.Log("Deleted Spawnpoint");
        }
    }
   
}
