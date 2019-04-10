using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameManager : MonoBehaviour {

    public GameObject gioButton;
    public GameObject ball;
    private bool gio = false;

    public void GameOverScreen()
    {
        if (ball.GetComponent<MoveBall>().isGameOver && !gio)
        {
            gioButton.SetActive(true);
            gio = true;
        }
    }


    private void Update()
    {
        GameOverScreen();
    }
}
