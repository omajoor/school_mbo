using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontrol : MonoBehaviour
{
    int min = 1;
    int max = 100;
    int gok = 50;
    int I = 0;

    // Use this for initialization
    void Start()
    {
        Debug.Log("welkom bij getallenkraker");
        Debug.Log("neem een getal in je hoofd tussen " + min + " en " + max);
        Debug.Log("is het getal " + gok + "?");
        Debug.Log("pijl omhoog = getal is hoger. pijl omlaag = getal is lager. enter = dat is het getal");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = gok;
            gok = Nieuwegok();
            Vraag();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = gok;
            gok = Nieuwegok();
            Vraag();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("gewonnen ez clap");
        }
    }
    int Nieuwegok()
    {
        int nieuweGok;
        nieuweGok = Random.Range(min, max);
        return nieuweGok;
    }



    void Vraag()
    {
        if (I < 5)
        {
            gok = (min + max) / 2;
            I++;
            Debug.Log("is het getal " + gok + "?");
            Debug.Log("pijl omhoog = getal is hoger. pijl omlaag = getal is lager. enter = dat is het getal");
        }
        else
        {
            Debug.Log("Too bad peanutbutter");
        }

    }


}



