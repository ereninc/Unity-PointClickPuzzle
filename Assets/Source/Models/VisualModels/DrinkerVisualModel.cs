using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkerVisualModel : VisualBaseModel
{
    public override void OnAction()
    {
        Animator.Play("OnTakeWater", 0, 0);
        ParticleSystem.Play();
    }
}
