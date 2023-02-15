using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int gone = 0;
    public int score;



    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        gone = 1;
        score = +10;
    }
    private void Update()
    {
        if (gone == 1)
        {

            gone = 0;

        }
       
        Debug.Log(score);
    }
    
    

    
}


