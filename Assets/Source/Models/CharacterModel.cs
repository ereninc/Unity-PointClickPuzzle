using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterModel : ObjectModel
{
    [SerializeField] private Transform characterGFX;
    [SerializeField] private Animator animator;

    public void OnLevelComplete()
    {
        characterGFX.SetActiveGameObject(true);
        animator.SetTrigger("levelCompleted");
    }
}