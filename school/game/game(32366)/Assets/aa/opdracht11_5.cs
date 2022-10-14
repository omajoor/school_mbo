using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opdracht11_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(5, -5, 0);
		gameObject.GetComponent<Renderer>().material.color = Color.magenta;
		transform.localScale = new Vector3(2,2,2);
		transform.eulerAngles = new Vector3(30, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
