using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    SpriteRenderer sr;
    public Sprite activeSprite;
    public bool isActive = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sr.sprite = activeSprite;
        isActive = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        sr = this.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
