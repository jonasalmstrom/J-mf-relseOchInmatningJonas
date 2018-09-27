using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame1 : MonoBehaviour
{
    [Header("Uppgift 1")]
    public float userValue;
    [Header("Uppgift 2")]
    public int diceValue = 10;
    public int dicePlus;
    public int diceMinus;

    [Header("Uppift 3")]
    public int dragonHp;
    public int playerHp = 100;
    public int dragonDamage;
    public int playerDamage;
    public int chance;
    public int dragChance;
    public int critChance;


    // Use this for initialization
    void Start()
    {
        Uppgift3a();
    }

    // Update is called once per frame
    void Update()
    {
        Uppgift1();

        Uppgift2();

        Uppgift3b();
    }

    void Uppgift1()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue += 2;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue /= 2;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log(string.Format("Värdet är {0}", userValue));
        }
    }

    void Uppgift2()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            dicePlus = Random.Range(1, 7);
            diceMinus = -Random.Range(1, 7);

            diceValue += dicePlus + diceMinus;

            Debug.Log(string.Format("{0}", diceValue));
        }

        if (diceValue >= 20)
        {
            Debug.Log(string.Format("You've won"));
        }

        if (diceValue <= 0)
        {
            Debug.Log(string.Format("You've lost"));
        }
    }

    void Uppgift3a()
    {
        dragonHp = Random.Range(100, 151);

        dragChance = Random.Range(0, 10);
        if (dragChance == 1)
        {
            dragonHp = dragonHp * 2;
        }

        Debug.Log(string.Format("Initial Dragon HP {0}", dragonHp));

    }

    void Uppgift3b()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            chance = Random.Range(0, 2);
            playerDamage = Random.Range(5, 26);
            dragonHp = dragonHp - playerDamage;
            Debug.Log(string.Format("Dragon HP is {0}", dragonHp));
            critChance = Random.Range(0, 21);

            if (critChance == 1)
            {
                dragonHp = 0;
            }

            if (chance == 1)
            {
                dragonDamage = Random.Range(10, 20);
                playerHp = playerHp - dragonDamage;
                Debug.Log(string.Format("Player HP is {0}", playerHp));
            }

            if (playerHp <= 0)
            {
                Debug.Log(string.Format("The player died"));
            }

            if (dragonHp <= 0)
            {
                Debug.Log(string.Format("The Dragon died"));
            }
        }
    }
}
