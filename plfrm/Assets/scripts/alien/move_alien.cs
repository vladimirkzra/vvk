using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_alien : MonoBehaviour
{

    GameObject player;
    float spd = 5;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, player.transform.position, Time.deltaTime * spd);
    }
}
