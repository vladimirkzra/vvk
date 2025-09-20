using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject plr;
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        float currentSpeed = (speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
        {
            plr.transform.position += new Vector3(currentSpeed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            plr.transform.position += new Vector3(-currentSpeed, 0, 0);
        }
    }
}
