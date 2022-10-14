using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthbar : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider healthBar;
    private static float health2;
    void Start()
    {
        health2 = 350f;
        healthBar.value = health2;
    }

    // Update is called once per frame
     public void healthmeter(float minus)
    {
        healthBar.value = minus;
    }
}
