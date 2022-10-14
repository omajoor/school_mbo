using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamecontroller : MonoBehaviour
{
    private enum States
    {
        kantoor_0, ladenkast_0, slot_0, kast_0, kast_1, kantoor_1, kantoor_2, end, slot_1, man_0, man_1,  vrijheid
    }
    public Text tekstvlak;
    private States currentState;
    // Use this for initialization
    void Start()
    {
        currentState = States.kantoor_0;
        tekstvlak.text = "welkom bij de escaperoom";


    }

    // Update is called once per frame
    void Update()
    {
        if (currentState == States.kantoor_0)
        {
            state_kantoor_0();

        }
        else if (currentState == States.ladenkast_0)
        {
            state_ladenkast_0();
        }
        else if (currentState == States.kantoor_1)
        {
            state_kantoor_1();
        }
        else if (currentState == States.slot_0)
        {
            state_slot_0();
        }

        else if (currentState == States.kantoor_2)
        {
            state_kantoor_2();
        }

        else if (currentState == States.slot_1)
        {
            state_slot_1();
        }

        else if (currentState == States.kast_0)
        {
            state_kast_0();
        }

        else if (currentState == States.kast_1)
        {
            state_kast_1();
        }

        else if (currentState == States.man_0)
        {
            state_man_0();
        }


        else if (currentState == States.man_1)
        {
            state_man_1();
        }

        else if (currentState == States.vrijheid)
        {
            state_vrijheid();
        }

        else if (currentState == States.end)
        {
            state_end();
        }
    }

    void state_kantoor_0()
    {
        tekstvlak.text = "Je wordt wakker in een oud en rommelig kantoor met een gruwelijke koppijn.Je ziet een ladekast(druk op L op naar de ladekast te lopen)";
        if (Input.GetKeyDown(KeyCode.L))
        {
            currentState = States.ladenkast_0;
        }
    }

    void state_ladenkast_0()
    {
        tekstvlak.text = "In de ladekast vind je een sleutel. Je pakt de sleutel op en loopt weer weg (druk op K om weg te lopen)";
        if (Input.GetKeyDown(KeyCode.K))
        {
            currentState = States.kantoor_1;
        }
    }

    void state_kantoor_1()
    {
        tekstvlak.text = "Je hoopt dat de sleutel past. je loopt naar de deur om te kijken of de sleutel past(druk op P om te passen) ";
        if (Input.GetKeyDown(KeyCode.P))
        {
            currentState = States.slot_0;
        }
    }

    void state_slot_0()
    {
        tekstvlak.text = "Helaas past de sleutel niet en gaat weer terug(druk op B om terug te gaan)";
        if (Input.GetKeyDown(KeyCode.B))
        {
            currentState = States.kantoor_2;
        }
    }
    void state_kantoor_2()
    {
        tekstvlak.text = "Je besluit om de ladekast eens grondig door te zoeken. Uiteindelijk vind je een geheim luikje met nog een sleutel erin. Je kijkt of deze sleutel wel past (druk op O om te kijken of deze wel past)  ";
        if (Input.GetKeyDown(KeyCode.O))
        {
            currentState = States.slot_1;
        }
    }

    void state_slot_1()
    {
        tekstvlak.text = "Ja de sleutel past! Je gaat door de deur en komt in een hele grote ruimte. In deze ruimte zie je een grote deur en een kast (druk op W om naar de kast te gaan)";
        if (Input.GetKeyDown(KeyCode.W))
        {
            currentState = States.kast_0;
        }
    }

    void state_kast_0()
    {
        tekstvlak.text = "De kast ziet er oud uit en de deuren zijn heel los,verder is er niks in de kast dus je besluit weer terug te lopen(druk op T om terug te gaan)";
        if (Input.GetKeyDown(KeyCode.T))
        {
            currentState = States.kast_1;
        }
    }

    void state_kast_1()
    {
        tekstvlak.text = "Op het moment dat je weg wilt lopen zie je een schaduw in je ooghoek dus besluit je in de kast te gaan. er loopt een man met sleutels langs naar de vorige kamer! je gaat uit de kast en trekt met brute kracht een deur van de kast en loopt richting de man( druk op M om naar de man te gaan) ";
        if (Input.GetKeyDown(KeyCode.M))
        {
            currentState = States.man_0;
        }
    }

    void state_man_0()
    {
        tekstvlak.text = "je loopt rustig richting de man. Je bereidt je voor om de man te slaan met de deur (druk op S om de man te slaan) ";
        if (Input.GetKeyDown(KeyCode.S))
        {
            currentState = States.man_1;
        }
    }
    void state_man_1()
    {
        tekstvlak.text = "Je slaat de man met de deur, pakt de sleutels, en rent snel richting de deur (druk op V om de deur te openen)";
        if (Input.GetKeyDown(KeyCode.V))
        {
            currentState = States.vrijheid;
        }
    }

    void state_vrijheid()
    {
        tekstvlak.text = "Je opent de deur en bent nu vrij! (druk op Enter om te eindigen)";
        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentState = States.end;
        }
    }

    void state_end()
    {
        tekstvlak.text = "Gefeliciteerd je bent vrij!";
        
    }
}

