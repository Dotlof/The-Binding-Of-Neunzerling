using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Bow : MonoBehaviour
{
    public GameObject Player;
    SpriteRenderer rend;
    public Animator animator;
    int Weapon;
    bool bowshot;
    public bool bowshotFinished;

    IEnumerator Reload()
    {
        animator.SetBool("Shoot", true);
        yield return new WaitForSeconds(1.5f);
        animator.SetBool("Shoot", false);
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            bowshotFinished = true;
        }
    }

    void Start()
    {
        rend = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Weapon = Player.gameObject.GetComponent<scr_Testchar>().Weapon;
        bowshot = Player.gameObject.GetComponent<scr_Testchar>().bowshot;
        if (Weapon == 2)
        {
            rend.enabled = true;
            if (bowshot == true)
            {
                StartCoroutine(Reload());
            }
        }
        else
        {
            rend.enabled = false;
        }

        //Debug.Log(Weapon);
    }
}
