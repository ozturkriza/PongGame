using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Week4
/// </summary>
public class Racket : MonoBehaviour
{
    public Transform ball;
    public float moveSpeed = 10;
    protected float Skore;

    //Week4 
    public Text ScoreText;

    public void SkorYap()
    {
        Skore++;
        ScoreText.text = Skore.ToString();
    }

    public bool IsGameOver()
    {
        if (Skore == 5)
            return true;
        return false;
    }

}
