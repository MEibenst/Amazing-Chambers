using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitchesActive : MonoBehaviour
{

    public List<SwitchController> switches;
    public GameObject doorToOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int activeCount = 0;
        foreach(SwitchController sw in switches)
        {
            if (sw.isActive)
            {
                activeCount = activeCount + 1;
            }
        }

        if (activeCount >= 3)
        {
            doorToOpen.GetComponent<SpriteRenderer>().enabled = false;
            doorToOpen.GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
}
