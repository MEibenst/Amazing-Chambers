using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertedControls : IControls
{

    
    public Vector2 Update()
    {
        Vector2 movement = new Vector2();
        movement.y = Input.GetAxisRaw("Horizontal");
        movement.x = Input.GetAxisRaw("Vertical");

        return movement;
    }
}
