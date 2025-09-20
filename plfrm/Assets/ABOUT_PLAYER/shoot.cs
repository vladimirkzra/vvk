using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Camera cam;
    private bool canShoot = true;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (canShoot == false) return;
            canShoot = false;
            GameObject instbullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            instbullet.GetComponent<bullet>().shoot(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            StartCoroutine(wait(0.2f));
        }
    }

    IEnumerator wait(float delay)
    {
        yield return new WaitForSeconds(delay);
        canShoot = true;
    }
}
