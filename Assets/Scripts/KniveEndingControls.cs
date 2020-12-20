using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KniveEndingControls : IControls
{
    Vector2 IControls.Update()
    {
        return new Vector2(1.01f, 65.52f);
    }
}
