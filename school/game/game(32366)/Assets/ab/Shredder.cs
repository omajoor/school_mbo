using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour
{
    // Start is called before the first frame update
 private void OnTriggerEnter(Collider collider)
    {
        Destroy (collider.gameObject);
    }}
