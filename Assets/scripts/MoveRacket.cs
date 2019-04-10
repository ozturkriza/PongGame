using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveRacket : Racket {
    public string dikeyEksen;


    //dikey eksen tanimlanacak
    // Use this for initialization
    void Start () {
        moveSpeed = 5.0f;
        //rb2 = GetComponent<Rigidbody2D>(); // bu oyun nesnesine ait RigidBody2 bileseni aliniyor ve atama yapiliyor.
    }

    private void FixedUpdate()
    {
      float y =  Input.GetAxisRaw(dikeyEksen);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, y) * moveSpeed;
        
       // Debug.Log(Skore+ " : " +gameObject.name);
        ScoreText.text = Skore.ToString();
    }

    public float GetScore()
    {
        return Skore;
    }
}
