using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opdracht11_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-4, 0, 0);
		gameObject.GetComponent<Renderer>().material.color = Color.black;
		transform.localScale = new Vector3(2,6,2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
