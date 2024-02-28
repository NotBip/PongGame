using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int Player1 = 0; 
    private int Player2 = 0; 
    public Text Player1Score;
    public Text Player2Score; 

    private void Update() 
    { 
        Player1Score.text = Player1.ToString(); 
        Player2Score.text = Player2.ToString(); 
    }

    public void increaseScore(String player) 
    { 
        if(player == "Player1")
            Player1++; 
        if(player == "Player2")
            Player2++; 
    }

}
