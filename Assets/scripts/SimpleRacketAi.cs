using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Week4
/// </summary>
public class SimpleRacketAi : Racket  {

    public float referenceVal = 2;
    public float xReferenceVal = 5;
    void FixedUpdate ()
    {
        var difY = Mathf.Abs(ball.position.y - transform.position.y);
        var difx = Mathf.Abs(ball.position.x - transform.position.x);

        if (difY > referenceVal && difx < xReferenceVal)
        {
            // top raketten asagi bir pozisyonda ise raket topu yakalamak icin asagi dogru hareket etmeli
            if (ball.position.y < transform.position.y)  
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * moveSpeed;

            //tersi
            else if(ball.position.y > transform.position.y)
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * moveSpeed;
        }
	}
}
