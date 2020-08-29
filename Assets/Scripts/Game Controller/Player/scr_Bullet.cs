using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Bullet : MonoBehaviour
{
    public GameObject Player;
    float speed = 1000;
    public bool LR;
    Vector3 moveLeft = new Vector3(-1, 0, 0);
    Vector3 moveRight = new Vector3(1, 0, 0);
    // Start is called before the first frame update
    
    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }

    void Start()
    {
        LR = Player.GetComponent<scr_Testchar>().RL;
        StartCoroutine(Despawn());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(LR);
        /*if (LR == true)
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.position += moveLeft * speed * Time.deltaTime;
        }
        else
        {
            transform.position += moveRight * speed * Time.deltaTime;
            transform.localScale = new Vector3(-1, 1, 1);
        }*/
    }
}
