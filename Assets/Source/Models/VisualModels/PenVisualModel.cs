using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenVisualModel : ObjectModel
{
    [SerializeField] private Animator animator;

    public void OnDraw()
    {
        animator.Play("OnDraw", 0, 0);
    }
}