using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public int gone = 0;



    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        gone = 1;
    }
    private void Update()
    {
        if (gone == 1)
        {

            gone = 0;

        }
        Debug.Log(gone);
    }
    
    

    
}


