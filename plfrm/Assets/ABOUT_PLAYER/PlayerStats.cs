using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int hp = 100;
    public int maxhp = 100;
    public GameObject hpLine;
    public TMP_Text hpText;
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
                UpdateHP();
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
            hpText.text = hp.ToString();
            if (hp <= 0)
            {
                SceneManager.LoadScene("menu");
            }
        }
    }
}
