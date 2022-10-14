using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashbinVisualModel : VisualBaseModel
{
    public override void OnAction()
    {
        Animator.Play("OnGarbage", 0, 0);
        ParticleSystem.Play();
    }
}