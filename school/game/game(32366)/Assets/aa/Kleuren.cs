﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kleuren : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if  ( Input.GetKeyDown(KeyCode.R)){
		
		gameObject.GetComponent<Renderer>().material.color = Color.red;
		}

		if  ( Input.GetKeyDown(KeyCode.G)){
		
		gameObject.GetComponent<Renderer>().material.color = Color.green;
		}
		if  ( Input.GetKeyDown(KeyCode.B)){
		
		gameObject.GetComponent<Renderer>().material.color = Color.blue;
		}
		if  ( Input.GetKeyDown(KeyCode.Y)){
		
		gameObject.GetComponent<Renderer>().material.color = Color.yellow;
		}

    }
}
