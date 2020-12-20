using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFinalDoor : MonoBehaviour
{
    public GameObject doorToOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openFinalDoor()
    {
        doorToOpen.GetComponent<SpriteRenderer>().enabled = false;
        doorToOpen.GetComponent<BoxCollider2D>().isTrigger = true;
    }
}
