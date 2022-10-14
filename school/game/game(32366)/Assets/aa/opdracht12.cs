using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opdracht12 : MonoBehaviour
{
    GameObject C1;
	GameObject C2;
	GameObject C3;
	GameObject C4;
	GameObject C5;
    void Start()
    {
        C1 = GameObject.Find("Cube1");
		C2 = GameObject.Find("Cube2");
		C3 = GameObject.Find("Cube3");
		C4 = GameObject.Find("Cube4");
		C5 = GameObject.Find("Cube5");

		C1.transform.position = new Vector3(0, 0, 0);
		C1.gameObject.GetComponent<Renderer>().material.color = Color.red;
		C1.transform.localScale = new Vector3(2,2,2);

		C2.transform.position = new Vector3(-4, 0, 0);
		C2.gameObject.GetComponent<Renderer>().material.color = Color.black;
		C2.transform.localScale = new Vector3(2,6,2);

		C3.transform.position = new Vector3(2, -2, 0);
		C3.transform.localScale = new Vector3(1,1,1);

		C4.transform.position = new Vector3(5, 5, 0);
		C4.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
		C4.transform.localScale = new Vector3(2,2,2);
		C4.transform.eulerAngles = new Vector3(0, 45, 0);

		C5.transform.position = new Vector3(5, -3, 0);
		C5.gameObject.GetComponent<Renderer>().material.color = Color.magenta;
		C5.transform.localScale = new Vector3(2,2,2);
		C5.transform.eulerAngles = new Vector3(30, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
