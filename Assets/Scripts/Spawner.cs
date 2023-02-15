using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject hatchet;
    Destroy destroy;
   // public GameObject prefabToSpawn;
    
   

    void Awake()
    {
        destroy = GameObject.Find("Floor").GetComponent<Destroy>();
    }

    void Update()
    {
        if ( destroy.gone == 1)
        {
            Instantiate(hatchet);
        }
        destroy.gone = 0;
    }
}
