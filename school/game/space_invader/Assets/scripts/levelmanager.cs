using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour {

    public float startDelay = 5f;

    public void LaadLevel(string level)
    {
        SceneManager.LoadScene(level);


    }

    public void StopSpel()
    {
        Application.Quit();
    }
}
