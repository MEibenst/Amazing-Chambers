using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalControls : IControls
{
   
    public Vector2 Update()
    {
        Vector2 movement = new Vector2();
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        return movement;
    }
}
