using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkerVisualModel : ObjectModel
{
    [SerializeField] private Animator animator;
    [SerializeField] private ParticleSystem splashParticle;

    public void OnTakeWater()
    {
        animator.Play("OnTakeWater", 0, 0);
        splashParticle.Play();
    }
}
