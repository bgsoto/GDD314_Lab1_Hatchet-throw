using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class movingTarget : MonoBehaviour
{

   // GameObject target;
    public float speed;
    public float length;
    //public float startPosition;
    private Vector3 startPosition;
   
    private void Start()
    {
        startPosition = transform.position;
       
    }
    // Update is called once per frame
    void Update()
    {

        float pingPong = Mathf.PingPong(Time.time * speed, length);
        
        transform.position = Vector3.Lerp(startPosition, new Vector3(3, 3, 0), pingPong);

    }
}
