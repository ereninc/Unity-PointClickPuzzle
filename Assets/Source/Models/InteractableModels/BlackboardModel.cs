using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackboardModel : InteractableBaseModel
{
    [SerializeField] private BlackboardVisualModel blackboardVisual;

    public override void Initialize()
    {
        base.Initialize();
        OnSpawn(InteractableTypes.Blackboard);
    }

    public override void OnInteract()
    {
        base.OnInteract();
    }

    public override void OnClickEnd()
    {
        blackboardVisual.OnBlackboardClick();
        base.OnClickEnd();
    }
}