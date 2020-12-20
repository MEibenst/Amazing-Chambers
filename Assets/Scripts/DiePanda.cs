using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiePanda : MonoBehaviour
{
    public Sprite deadPanda;
    public GameObject panda;
    public GameObject blood;


    public void executePanda()
    {
        panda.GetComponent<SpriteRenderer>().sprite = deadPanda;
        blood.SetActive(true);
    }
}
