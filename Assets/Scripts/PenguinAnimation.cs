using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinAnimation : MonoBehaviour
{
    Animator anim;

    private void Awake()
    {
        anim = this.GetComponent<Animator>();
    }

    public void HeartEnding()
    {
        anim.SetTrigger("HeartEnding");
    }

    public void CrossEnding()
    {
        anim.SetTrigger("CrossEnding");
    }

    public void KniveEnding()
    {
        anim.SetTrigger("KniveEnding");
    }
}
