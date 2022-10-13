using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : ControllerBaseModel
{
    [SerializeField] private Animator animator;

    public override void OnStateChange(GameStates gameStates)
    {
        if (gameStates == GameStates.Main)
        {
            base.OnStateChange(gameStates);
            Invoke(nameof(OnLevelStart), 0.5f);
        }
    }

    public void OnLevelStart()
    {
        animator.Play("OnShow", 0, 0);
    }
}