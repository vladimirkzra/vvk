using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    

    
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        { 
            GameObject instbullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            if (Input.GetAxis("Horizontal") < 0)
            {
                instbullet.GetComponent<bullet>().isItLeft = true;
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                instbullet.GetComponent<bullet>().isItLeft = false;
            }
            else if (Input.GetAxis("Horizontal") == 0)
            {

            }



        }
    }
}
