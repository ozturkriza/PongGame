using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text Score;
    public Text highScore;
    public MoveRacket playerRacket;

    // Use this for initialization
    void Start()
    {
        highScore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }

    public void SaveScore()
    {
        float  skor = playerRacket.GetScore();
        Score.text = skor.ToString();

        if (skor > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", skor);
            highScore.text = skor.ToString();
        }
    }


    public void ResetHS()
    {
        PlayerPrefs.DeleteAll();
        highScore.text = "0";
    }
}
