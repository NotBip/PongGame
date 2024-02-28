using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{   
    private Vector2 player1; 
    private Vector2 player2;
    private Rigidbody2D rb; 
    private float movementSpeed = 10; 


    private void Start() 
    { 
        rb = GetComponent<Rigidbody2D>(); 
    }

    private void Update()
    {   
        if(gameObject.name == "Player1") 
            player1 = new Vector2(0, Input.GetAxisRaw("Vertical1"));
        

        if(gameObject.name == "Player2")
            player2 = new Vector2(0, Input.GetAxisRaw("Vertical2"));


    }

    private void FixedUpdate() 
    {  
        if(gameObject.name == "Player1") 
                rb.velocity = player1 * movementSpeed; 

        

        if(gameObject.name == "Player2") { 
                rb.velocity = player2 * movementSpeed; 
     
        }
    }

}
