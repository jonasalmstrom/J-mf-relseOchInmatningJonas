using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JämförelseOchInmatning : MonoBehaviour
{
    public bool IsChecked;

    public int MyIntValue = 10;

    // Use this for initialization
    void Start()
    {
        if (IsChecked == true)
        {
            Debug.Log("It's true.");
        }
        else
        {
            Debug.Log("Nej.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // ==lika med
        // != inte lika med
        // <= mindre än eller lika med
        // >större än eller lika med
        // > större än
        // <mindre än
        // && betyder "Och"
        // || eller (alt gr + <)
       // if (MyIntValue == 10 && IsChecked == true)
        {
            //print("Måndag");
        }
       // else if (MyIntValue == 9)
        {
            //print("Tisdag");
        } 
        //else
        {
           // print("Okänd dag");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            print("Reload");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            // 0 1 2 3 4 5 6 7 8 9 
            Random.Range(0, 10);
            // 0.032f, 10.000f
            print(Random.Range(0f, 10f));
            print("Lean Left");
        }
    }
}
