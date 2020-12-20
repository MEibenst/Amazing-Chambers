using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableKey : MonoBehaviour
{
    /*[SerializeField]
    List<GameObject> OtherKeys;*/
    [SerializeField]
    GameObject DoorToOpen;
    public string DialogName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.getInstance().flowchart.SendFungusMessage(DialogName);
        /*foreach (GameObject go in OtherKeys) {
            Destroy(go);
        }*/
        DoorToOpen.GetComponent<SpriteRenderer>().enabled = false;
        DoorToOpen.GetComponent<BoxCollider2D>().isTrigger = true;
        this.GetComponent<AudioSource>().Play();
        //Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
