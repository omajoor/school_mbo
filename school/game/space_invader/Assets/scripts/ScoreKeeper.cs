using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    

public class ScoreKeeper : MonoBehaviour {

    public Text scoreText;
    private static int score ;

    // Use this for initialization
    void Start () {
        scoreText.text =  "score " + score.ToString();
        score = 0;
	}
	
	// Update is called once per frame


    public void ScoreUp(int points)
    {
        score += points;
        scoreText.text = "score " + score.ToString();
    }
}
