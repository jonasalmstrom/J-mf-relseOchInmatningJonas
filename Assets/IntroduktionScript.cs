using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroduktionScript : MonoBehaviour
{
    //public = syns i unity
    public int testInt = 5;

    public float testFloat = 1.0f;

    public double testDouble = 1.0d;

    public bool testBool = true;

    public char testChar = 'a';

    public string testString = "Blippblopp";

    public string sentence1;

    public string sentence2;

    public string sentence3;

    public float number;

    public int @base;

    public string username;

    [Range(1, 360)]
    public float angle;

    public float pieces;

    public float radius;

    public int damage;

    public int life;

    public int demons;

    public int minDamage;

    public int maxDamage;

    public decimal count = 2;

    public float countMulti;


    void Start()
    {
        print(testInt);

        print(5 * 93);

        print(testInt * testInt);

        print(5f / 2);

        Debug.Log("SkrrSkrr");

        Debug.LogWarning(10f / 2);

        print("hihi");

        Debug.Log("jonas almström, lbs göteborg, su18a, spelutveckling");

        TestFunktion();

        Uppgift1();

        Uppgift2();

        Uppgift3();

        Uppgift4();

        Uppgift5();

        Uppgift5a();

        Uppgift6();

        Uppgift7();

        Uppgift8();

        Uppgift10();

    }

    void TestFunktion()
    {
        Debug.Log("Detta är min testfunktion()");
    }

    void Uppgift1()
    {
        Debug.Log(string.Format("Svaret på (963 * 421) - (175463 / 87) är {0}", (963f * 421f) - (175463f / 87f)));
    }

    void Uppgift2()
    {
        Sentence1();
        Sentence2();
        Sentence3();
    }

    void Uppgift3()
    {
        Debug.Log(string.Format("Talet {0} upphöjt med 2 är {1} och kvadratroten ur {0} blir {2}", number, Mathf.Pow(number, 2f), Mathf.Sqrt(number)));

    }

    void Uppgift4()
    {
        Debug.Log(string.Format("Arean på en triangel med höjden 8 och basen {0} är {1} m^2", @base, (8 * @base) / (2)));
    }

    void Uppgift5()
    {
        Debug.Log(string.Format("Om hela tårtan delas upp i lika stora delar, varav delarna ska ha vinkeln {0} så blir det {1} bitar per person.", angle, (360 / angle)));
    }

    void Uppgift5a()
    {
        Debug.Log(string.Format("Om tårtarn delas upp i {0} bitar, så blir vinkeln på varje bit {1}", pieces, (360 / pieces)));
    }

    void Uppgift6()
    {
        Debug.Log(string.Format("Boss {0} of Doom", username));
    }

    void Uppgift7()
    {
        Debug.Log(string.Format("Volymen på 2978 klot med radien {0}m är {1}m^3", radius, (((4 * 3.14 * Mathf.Pow(radius, 2f) / 3) * 2978))));
    }

    void Uppgift8()
    {

        Debug.Log(string.Format("Det krävs {0} attacker för att döda en demon med 890000 liv.", (890000 / damage)));

        //A
        Debug.Log(string.Format("Det krävs {0} attacker för att döda en demon med {1} liv.", (life / damage), life));

        //B
        Debug.Log(string.Format("Det krävs {0} attacker för att döda {1} demoner med {2} liv var.", ((life * demons) / damage), demons, life));

        //C
        Debug.Log(string.Format("Det krävs som minst {3} attacker och som mest {0} attacker för att döda {1} demoner med {2} liv var.", ((life * demons) / minDamage), demons, life, (life * demons) / maxDamage));
        Debug.Log(string.Format("Antalet attacker i snitt är {0}", ((((life * demons) / minDamage) + (life * demons) / maxDamage) / 2)));
    }

    void Uppgift9()
    {
        Debug.Log(string.Format("Värde {0}", (count)));
        count = count * 2;
    }

    void Uppgift10()
    {
        Debug.Log(string.Format("Värdet {0} multiplicerat med 3 och sedan dividerat på 2 är {1}", countMulti, ((countMulti * 3) / 2)));
    }
   
    void Sentence1()
    {
        Debug.Log(sentence1);
    }

    void Sentence2()
    {
        Debug.Log(sentence2);
    }

    void Sentence3()
    {
        Debug.Log(sentence3);
    }

    void Update()
    {
        //Uppgift9();

    }
}
