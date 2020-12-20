using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    public string showOnlyWithThisAsLastLevel;
    bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        isActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            if (showOnlyWithThisAsLastLevel == GameManager.getInstance().getLastVisitedRoom())
            {
                this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.getInstance().addItem(this.gameObject);
        this.GetComponent<SpriteRenderer>().enabled = false;
        this.GetComponent<BoxCollider2D>().enabled = false;
        isActive = false;
    }
}
