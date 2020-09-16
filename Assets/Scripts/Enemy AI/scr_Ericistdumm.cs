using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Ericistdumm : MonoBehaviour
{
    public bool egalwie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (egalwie == true)
        {
            Destroy(gameObject);
        }
    }
}
