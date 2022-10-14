using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseVisualModel : VisualBaseModel
{
    public override void OnAction()
    {
        Animator.Play("OnWatered", 0, 0);
        ParticleSystem.Play();
    }
}