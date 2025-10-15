using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
   public static Scoreboard instance;

   [SerializeField] private Text currentScore;
   [SerializeField] private Text highScore;

   private int score;

   private void Awake() {
    if (instance == null)
        instance = this;
    }

private void Start() {
    score = 0;
    currentScore.text = score.ToString();
    highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    //UpdateScore();
}

private void UpdateHighScore() {
    int savedHigh = PlayerPrefs.GetInt("HighScore", 0);
    if (score > savedHigh) {
        PlayerPrefs.SetInt("HighScore", score);
        highScore.text = score.ToString();
    }
}

public void UpdateScore() {
    score++;
    currentScore.text = score.ToString();
    UpdateHighScore();
}
}