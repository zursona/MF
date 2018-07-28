using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Text scoreText;
    private float currentScore = 0;
    public int difficulty = 1;
    public int maxDifficulty = 10;
    public int scoreToNext = 100;
    // Use this for initialization
    void Start () {
        scoreText.text = "0";
    }
	
	// Update is called once per frame
	void Update () {
        if (currentScore >= scoreToNext)
        {
            LevelUp();
        }

        currentScore += Time.deltaTime;
        scoreText.text = ((int)currentScore).ToString();
    }

    private void LevelUp()
    {

    }
}
