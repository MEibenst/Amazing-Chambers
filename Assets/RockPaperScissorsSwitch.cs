using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPaperScissorsSwitch : MonoBehaviour
{
    public RockPaperScissorsScript enemyChoiceScript;
    public string choice;
    private string winner;
    public GameObject doorToOpen;
    public List<GameObject> toDeactivate;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        winner = enemyChoiceScript.winnerIs(choice);
        Debug.Log(winner);
        if(winner == "Player")
        {
            enemyChoiceScript.showChoice();
            doorToOpen.GetComponent<SpriteRenderer>().enabled = false;
            doorToOpen.GetComponent<BoxCollider2D>().isTrigger = true;
            this.GetComponent<BoxCollider2D>().enabled = false;
            foreach(GameObject go in toDeactivate)
            {
                go.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
        else
        {
            enemyChoiceScript.showChoice();
            enemyChoiceScript.nextRound();
        }
    }
}
