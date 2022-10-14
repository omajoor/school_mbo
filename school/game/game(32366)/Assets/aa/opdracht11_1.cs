using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opdracht11_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
		gameObject.GetComponent<Renderer>().material.color = Color.red;
		transform.localScale = new Vector3(2,2,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
