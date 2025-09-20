using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int hp = 100;
    public int maxhp = 100;
    public GameObject hpLine;
    private void Start()
    {
        StartCoroutine(regenHp());
    }

    IEnumerator regenHp()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            if (hp < maxhp)
            {
                hp += 1;
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Alien"))
        {
            hp -= 10;
            UpdateHP();
        }
    }

    private void UpdateHP()
    {
        if (hp < maxhp)
        {
            hpLine.transform.localScale = new Vector3(hp/maxhp, 0.1f, 0);
        }
    }
}
