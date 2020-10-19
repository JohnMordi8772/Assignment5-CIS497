/** John Mordi* 
 * Assignment#5 - 2D Prototype* 
 * Manages gem collection and point increases, also manages the finish line*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static int score = 0;
    public static bool win = false;

    void Update()
    {
        if (!win)
            scoreText.text = "Score: " + score;
        else
            scoreText.text = "You win!\nYour score was " + score + " out of 10";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Gem"))
        {
            score++;
        }
        if(collision.CompareTag("Finish"))
        {
            win = true;
        }
    }
}
