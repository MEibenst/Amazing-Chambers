using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPaperScissorsScript : MonoBehaviour
{
    public string actualChoice;
    public GameObject choiceLabel;
    public Sprite rockSprite;
    public Sprite paperSprite;
    public Sprite scissorsSprite;

    public void nextRound()
    {
        actualChoice = valueToString(Random.Range(1, 4));

    }

    private string valueToString(int value)
    {
        if(value == 1)
        {
            return "Rock";
        }
        else if (value == 2)
        {
            return "Paper";
        }
        return "Scissors";
        
    }

    private void Start()
    {
        nextRound();

    }

    public string winnerIs(string playerChoice)
    {
        if(actualChoice == "Rock" && playerChoice == "Paper")
        {
            return "Player";
        }
        else if(actualChoice == playerChoice)
        {
            return "None";
        }
        else if(actualChoice == "Rock" && playerChoice == "Scissors")
        {
            return "Enemy";
        }
        else if (actualChoice == "Paper" && playerChoice == "Scissors")
        {
            return "Player";
        }
        else if (actualChoice == "Paper" && playerChoice == "Rock")
        {
            return "Enemy";
        }
        else if (actualChoice == "Scissors" && playerChoice == "Rock")
        {
            return "Player";
        }
        else if (actualChoice == "Scissors" && playerChoice == "Paper")
        {
            return "Enemy";
        }

        return "None";
    }

    public void showChoice() { 
        if(actualChoice == "Rock")
        {
            choiceLabel.GetComponent<SpriteRenderer>().sprite = rockSprite;
        }
        else if(actualChoice == "Paper")
        {
            choiceLabel.GetComponent<SpriteRenderer>().sprite = paperSprite;
        }
        else if(actualChoice == "Scissors")
        {
            choiceLabel.GetComponent<SpriteRenderer>().sprite = scissorsSprite;
        }
    }

}
