using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {
    public float moveSpeed =15;
    public GameObject solRaket;
    public GameObject sagRaket;
    AudioSource source;
    public bool isGameOver = false;


    // Use this for initialization
    void Start ()
    {
        source = GetComponent<AudioSource>();
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * moveSpeed;
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (isGameOver)
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            
            return;
        }
        if (other.gameObject.name=="solduvar")
        {
            SkorYap(sagRaket);
            PlayMusic();
        }

        if (other.gameObject.name =="sagduvar")
        {
            SkorYap(solRaket);
            PlayMusic();
        }

        if (other.gameObject.name == "solraket")
        {
            // eger top raketin ust tarafina carparsa yonunu ayarla x =1, y si hesaplanacak
           float yFark = transform.position.y - other.gameObject.transform.position.y;  // top ile raketin y degerlerinin farkini al
           float raketUzunluk = other.collider.bounds.size.y;  //raketin uzunlugunu hesapla

           var y = yFark / raketUzunluk;  // burada var otomatik olarak float oluyor.
           Vector2 direction = new Vector2(1, y);  // buldugunuz yon vektoru
           GetComponent<Rigidbody2D>().velocity = direction * moveSpeed;  // bu vektoru topun hizina eklerse
        }

        if (other.gameObject.name == "sagraket")
        {
            // eger top raketin ust tarafina carparsa yonunu ayarla x =-1, y si hesaplanacak

            float yFark = transform.position.y - other.gameObject.transform.position.y;
            float raketUzunluk = other.collider.bounds.size.y;

            var y = yFark / raketUzunluk;  // burada var otomatik olarak float oluyor.
            Vector2 direction = new Vector2(-1, y);

            GetComponent<Rigidbody2D>().velocity = direction * moveSpeed;
        }
    }

    private void SkorYap(GameObject racket)
    {
        if (racket.GetComponent<Racket>().IsGameOver())
        {
            isGameOver = true;
            return;
        }

        racket.GetComponent<Racket>().SkorYap();
    }

    private void PlayMusic()
    {
        if (!source.isPlaying)
            source.Play();
    }
}
