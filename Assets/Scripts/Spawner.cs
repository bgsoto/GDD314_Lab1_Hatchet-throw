using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject hatchet;
    Destroy destroy;
    Target target;
   // public GameObject prefabToSpawn;
    
   

    void Awake()
    {
        destroy = GameObject.Find("Floor").GetComponent<Destroy>();
        target = GameObject.Find("Target3").GetComponent<Target>();
    }

    void Update()
    {
        if ( destroy.gone == 1)
        {
            Instantiate(hatchet);
        }
        //destroy.gone = 0;
       
        else if ( target.gone == 1) 
        {
            Instantiate(hatchet);
        }
        destroy.gone = 0;
        target.gone = 0;
    }
}
