using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorModel : ObjectModel
{
    [SerializeField] private Animator animator;

    public void OnOpen() 
    {
        animator.Play("OnOpen", 0, 0);
    }
}
