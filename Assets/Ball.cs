using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb; 
    private Vector2 ballMovement; 
    private float ballXSpeed = 15; 
    private float ballYSpeed = -5; 
    private ScoreManager scoreManager; 

    private void Start() 
    {   
        scoreManager = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<ScoreManager>(); 
        rb = GetComponent<Rigidbody2D>();   
    }

    private void Update()
    { 
        ballMovement = new Vector2(ballXSpeed, ballYSpeed);
    }

    private void FixedUpdate()
    { 
        rb.velocity = ballMovement; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        if(collision.gameObject.tag == "Player")
            ballXSpeed *= -1; 
        if(collision.gameObject.tag == "Wall")
            ballYSpeed *= -1; 
        if(collision.gameObject.tag == "Score" && this.transform.position.x > 0) {
            scoreManager.increaseScore("Player1"); 
            gameOver();
        }
        if(collision.gameObject.tag == "Score" && this.transform.position.x < 0) { 
            scoreManager.increaseScore("Player2"); 
            gameOver(); 
        }
    }

    private void gameOver() 
    { 
        transform.position = new Vector2(0,0); 
    }


}
