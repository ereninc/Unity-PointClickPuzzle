using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashbinVisualModel : ObjectModel
{
    [SerializeField] private Animator animator;
    [SerializeField] private ParticleSystem paperBlastParticle;

    public void OnTrash() 
    {
        animator.Play("OnGarbage", 0, 0);
        paperBlastParticle.Play();
    }
}