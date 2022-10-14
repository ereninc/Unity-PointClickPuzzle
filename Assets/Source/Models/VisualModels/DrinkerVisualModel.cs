using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkerVisualModel : ObjectModel
{
    [SerializeField] private Animator animator;

    public void OnTakeWater()
    {
        animator.Play("OnTakeWater", 0, 0);
    }
}
