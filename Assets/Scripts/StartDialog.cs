using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDialog : MonoBehaviour
{
    public string dialogName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.getInstance().flowchart.SendFungusMessage(dialogName);
    }
}
