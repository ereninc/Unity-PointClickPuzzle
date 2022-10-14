using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackboardModel : InteractableBaseModel
{
    [SerializeField] private EventModel blackboardInteractEventModel;

    public override void Initialize()
    {
        base.Initialize();
        OnSpawn(InteractableTypes.Blackboard);
    }

    public override void OnInteract()
    {
        base.OnInteract();
        blackboardInteractEventModel?.Invoke();
    }
}