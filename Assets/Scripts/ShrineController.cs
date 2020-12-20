using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrineController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach(GameObject go in GameManager.getInstance().getItemList())
        {
            if (go.name == "ItemKnive")
            {
                GameManager.getInstance().flowchart.SetBooleanVariable("KniveItem", true);
            }
            else if (go.name == "ItemHeart")
            {
                GameManager.getInstance().flowchart.SetBooleanVariable("HeartItem", true);
            }
            else if (go.name == "ItemCross") {
                GameManager.getInstance().flowchart.SetBooleanVariable("CrossItem", true);
            }
        }

        GameManager.getInstance().flowchart.SetIntegerVariable("ItemsCollected", GameManager.getInstance().getItemList().Count);

        GameManager.getInstance().flowchart.SendFungusMessage("ShrineDialog");

    }

}
