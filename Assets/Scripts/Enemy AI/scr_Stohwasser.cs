using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class scr_Stohwasser : MonoBehaviour
{
    float Speed = 100;
    float charx;
    float chary;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {

    }


    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(charx, chary, 0) * Time.deltaTime * Speed;
    }
}
