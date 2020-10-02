using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Bow : MonoBehaviour
{
    public GameObject Player;
    SpriteRenderer rend;
    int Weapon;
    
    void Start()
    {
        rend = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Weapon = Player.gameObject.GetComponent<scr_Testchar>().Weapon;
        if (Weapon == 2)
        {
            rend.enabled = true;
        }
        else
        {
            rend.enabled = false;
        }

        //Debug.Log(Weapon);
    }
}
