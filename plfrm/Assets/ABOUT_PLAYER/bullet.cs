using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bullet_;
    int speed = 10;
    private Vector3 lookV;
    public Camera cam;

    private void Start()
    {
        StartCoroutine(del());
    }

    IEnumerator del()
    {
        yield return new WaitForSeconds(10);
        Destroy(bullet_);
    }

    public void shoot(Vector2 v)
    {
        Vector3 pos = Vector3.ClampMagnitude(new Vector3(Screen.width / 2 - v.x, Screen.height / 2 - v.y, 0), 1);
        print(pos);
        lookV = pos;
    }

    void Update()
    {
        if (lookV == null) return;
        gameObject.transform.position -= lookV / speed;
    }
}
