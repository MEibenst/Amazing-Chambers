using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockKnock : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<PlayerController>().playDialogKnock();
    }
}
