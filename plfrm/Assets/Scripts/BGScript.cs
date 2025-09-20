using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScript : MonoBehaviour
{

    public Camera Camera;
    public GameObject bg;
    public GameObject Player;
    public float offsetX = 0;
    public float offsetY = 0;
    public float offsetZ = 0;

    void Update()
    {
        Camera.transform.position = Vector3.Lerp(Camera.transform.position, Player.transform.position + new Vector3(0, 0, -2), Time.deltaTime * 3);

        Vector3 camPos = Camera.transform.position;
        bg.transform.position = new Vector3(camPos.x/1.1f + offsetX, camPos.y / 1.01f + offsetY, offsetZ);
    }
}
