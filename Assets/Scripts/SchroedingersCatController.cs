using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchroedingersCatController : MonoBehaviour
{
    public int aliveOrDead;
    public Sprite catAlive;
    public Sprite catDead;
    public GameObject doorAlive;
    public GameObject doorDead;

    public List<GameObject> triggers;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.getInstance().flowchart.SendFungusMessage("SchrödingerLooksInBox");
        foreach(GameObject go in triggers)
        {
            go.SetActive(false);
        }
        if(collision.gameObject.tag == "Player")
        {
            if(aliveOrDead <= 11)
            {
                this.GetComponent<SpriteRenderer>().sprite = catAlive;
                doorDead.GetComponent<SpriteRenderer>().enabled = true;
                doorDead.GetComponent<BoxCollider2D>().isTrigger = false;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().sprite = catDead;
                doorAlive.GetComponent<SpriteRenderer>().enabled = true;
                doorAlive.GetComponent<BoxCollider2D>().isTrigger = false;
            }
        }


    }

    private void Start()
    {
        aliveOrDead = Random.Range(1, 21);
    }

}
