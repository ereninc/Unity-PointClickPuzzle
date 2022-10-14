using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseVisualModel : ObjectModel
{
    [SerializeField] private Animator animator;
    [SerializeField] private ParticleSystem sparkleParticle;

    public void OnWatered() 
    {
        animator.Play("OnWatered", 0, 0);
        sparkleParticle.Play();
    }
}
