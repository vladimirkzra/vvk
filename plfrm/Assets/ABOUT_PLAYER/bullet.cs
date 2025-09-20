using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public bool isItLeft;
    public bool isItUp;
    byte speed = 15;
    
    void Update()
    {
        if (isItLeft)
        {
            gameObject.transform.position -= new Vector3(speed*Time.deltaTime,0);
        }
        if (!isItLeft)
        {
            gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0);
        }
        
    }
}
