        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alien_sp : MonoBehaviour
{
    GameObject[] spawners;
    public GameObject alienPrefab;
    void Start()
    {
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
        StartCoroutine(interval());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator interval()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.2f, 0.5f));
            Instantiate(alienPrefab, spawners[Random.Range(0,spawners.Length)].transform.position,Quaternion.identity);

        }
    }
}
