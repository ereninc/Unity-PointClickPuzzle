using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenVisualModel : VisualBaseModel
{
    public override void OnAction()
    {
        Animator.Play("OnDraw", 0, 0);
    }
}